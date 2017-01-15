namespace vn3xt.Plagiarism.PlagScan
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;

    public sealed class PlagScanClient
    {
        private string username;

        private string password;

        private string version;

        public PlagScanClient(string username, string password)
            : this(username, password, "2.1")
        {
        }

        public PlagScanClient(string username, string password, string version)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("username cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("password cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(version))
            {
                throw new ArgumentException("version cannot be null or empty.");
            }

            this.username = username;

            this.password = password;

            this.version = version;

        }

        public async Task<SubmitResult> Submit(string filePath)
        {
            return await this.Submit(File.ReadAllBytes(filePath));
        }

        public async Task<SubmitResult> Submit(byte[] bytes)
        {
            var str = await this.Send("submit",
                (content) =>
                {
                    var fileContent = new ByteArrayContent(bytes);
                    content.Add(fileContent, "DATA", "Testfilename.txt");
                });

            return this.Deserialize<SubmitResult>(str);
        }

        public async Task<string> Retrieve(long pid, RetreiveReportMode mode)
        {
            var str = await this.Send("Retrieve",
                (content) =>
                {
                    content.Add(new StringContent("PID"), pid.ToString());
                    content.Add(new StringContent("MODE"), ((byte)mode).ToString());
                });

            return str;
        }

        public async Task<string> Check(long pid)
        {
            var str = await this.Send("Check",
                (content) =>
                {
                    content.Add(new StringContent("PID"), pid.ToString());
                });

            return str;
        }

        public async Task<string> Delete(long pid)
        {
            var str = await this.Send("Delete",
                (content) =>
                {
                    content.Add(new StringContent("PID"), pid.ToString());
                });

            return str;
        }

        public async Task<string> List(RetreiveReportMode mode)
        {
            return await this.List(0, 0, mode);
        }

        public async Task<string> List(int number, RetreiveReportMode mode)
        {
            return await this.List(0, number, mode);
        }

        public async Task<string> List(int start, int number, RetreiveReportMode mode)
        {
            var str = await this.Send("List",
                (content) =>
                {
                    content.Add(new StringContent("START"), start.ToString());
                    content.Add(new StringContent("NUM"), number.ToString());
                    content.Add(new StringContent("MODE"), ((byte)mode).ToString());
                });

            return str;
        }

        public async Task<GetConfigResult> GetConfig()
        {
            var str = await this.Send("GetConfig",
                (content) => { });

            return this.Deserialize<GetConfigResult>(str);
        }

        private async Task<string> Send(string method, Action<MultipartFormDataContent> extend)
        {
            using (var client = new HttpClient())
            {
                using (var content = new MultipartFormDataContent())
                {
                    var values = new[]
                    {
                        new KeyValuePair<string, string>("USER",this.username),
                        new KeyValuePair<string, string>("KEY",this.password),
                        new KeyValuePair<string, string>("VERSION",this.version),
                        new KeyValuePair<string, string>( "METHOD",method),
                    };

                    foreach (var keyValuePair in values)
                    {
                        content.Add(new StringContent(keyValuePair.Value), keyValuePair.Key);
                    }

                    extend(content);

                    var result = client.PostAsync("https://api.plagscan.com", content).Result;

                    return await result.Content.ReadAsStringAsync();
                }
            }
        }

        private T Deserialize<T>(string str)
           where T : class
        {

            var doc = new System.Xml.XmlDocument();
            doc.LoadXml(str);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(
                Newtonsoft.Json.JsonConvert.SerializeXmlNode(
                    doc.DocumentElement,
                    Newtonsoft.Json.Formatting.None,
                    true));
        }
    }
}
