namespace vn3xt.Plagiarism.PlagScan
{
    using System.Xml.Serialization;

    public sealed class GetConfigResult
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "USERID")]
        public int UserId
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "TITLE")]
        public string Title
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "FIRSTNAME")]
        public string FirstName
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "LASTNAME")]
        public string LastName
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "EADDRESS")]
        public string Email
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "LANG")]
        public Language Language
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "SHARE")]
        public ShareMode Share
        {
            get;

            set;
        }

        /// <summary>
        /// Check against the Internet for plagiarism : false (do not compare to web sources), true (compare to web sources)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "WEB")]
        [Newtonsoft.Json.JsonConverter(typeof(BooleanConverter))]
        public bool Web
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "SSTY")]
        public AnalysisSensitivityMode AnalysisSensitivity
        {
            get;

            set;
        }

        /// <summary>
        /// Set from which percentage of matched text the yellow PlagLevel starts: 10 is the default, 
        /// meaning over one percent of text matching, can take any integer value up to 1000 (for 100%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "YLW")]
        public int YellowPlagLevel 
        {
            get;

            set;
        }

        /// <summary>
        /// Set from which percentage of matched text the red PlagLevel starts: 50 is the default, 
        /// meaning over five percent of text matching, can take any integer value up to 1000 (for 100%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "RED")]
        public int RedPlagLevel
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "DEL")]
        public AutoDeleteMode AutoDelete
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "EMAIL")]
        public EmailNotificationMode EmailNotification
        {
            get;

            set;
        }

        /// <summary>
        ///  Autostart plagiarism checks: false do not start analysis automatically, true start analysis automatically as soon as possible
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AUTO")]
        [Newtonsoft.Json.JsonConverter(typeof(BooleanConverter))]
        public bool AutoStart
        {
            get;

            set;
        }

        [Newtonsoft.Json.JsonProperty(PropertyName = "DOCX")]
        public DocxGenerationMode DocxGeneration
        {
            get;

            set;
        }
    }
}