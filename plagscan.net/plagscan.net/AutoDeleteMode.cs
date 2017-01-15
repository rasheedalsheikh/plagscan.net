namespace vn3xt.Plagiarism.PlagScan
{
    using System;
    
    public enum AutoDeleteMode
    {
        /// <summary>
        /// Automatically remove data after after one week
        /// </summary>
        AfterOneWeek = 0,

        /// <summary>
        /// Automatically remove data after after four weeks
        /// </summary>
        AfterFourWeeks = 1,

        /// <summary>
        /// Automatically remove data after after six months
        /// </summary>
        AfterSixMonths = 2,

        /// <summary>
        /// never delete automatically
        /// </summary>
        Never = 3
    }
}
