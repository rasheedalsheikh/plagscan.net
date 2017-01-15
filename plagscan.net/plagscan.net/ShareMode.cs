namespace vn3xt.Plagiarism.PlagScan
{
    using System;

    /// <summary>
    /// SHARE Share my documents for analysis with and compare to
    /// </summary>
    public enum ShareMode
    {
        /// <summary>
        /// no one (compare to web sources only if activated)
        /// </summary>
        WebSourcesOnly = 0,

        /// <summary>
        /// no one (compare to my documents and web sources if activated)
        /// </summary>
        MyDocumentsAndWebSources = 1,

        /// <summary>
        /// my institution (compare to institution database and web sources if activated)
        /// </summary>
        MyInstitution = 2,

        /// <summary>
        /// general database (compare with general database and web sources if activated)
        /// </summary>
        GeneralDatabase = 3
    }
}