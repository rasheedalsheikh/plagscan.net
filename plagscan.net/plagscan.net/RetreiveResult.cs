namespace vn3xt.Plagiarism.PlagScan
{
    using System.Xml.Serialization;

    public sealed class RetreiveResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "MSG")]
        public string Message
        {
            get;

            set;
        }
    }
}