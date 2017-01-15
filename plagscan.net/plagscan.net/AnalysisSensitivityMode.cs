namespace vn3xt.Plagiarism.PlagScan
{
    using System;

    public enum AnalysisSensitivityMode
    {
        /// <summary>
        /// only report longer matches
        /// </summary>
        low = 0,

        /// <summary>
        /// balanced approach, recommended
        /// </summary>
        Medium = 1,

        /// <summary>
        /// report many, even short matches
        /// </summary>
        High = 2
    }
}
