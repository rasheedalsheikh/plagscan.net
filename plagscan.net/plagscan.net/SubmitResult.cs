namespace vn3xt.Plagiarism.PlagScan
{
    using System.Xml.Serialization;

    public sealed class SubmitResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "PID")]
        public long ProcessId
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MSG")]
        public string Message
        {
            get;

            set;
        }
    }
}