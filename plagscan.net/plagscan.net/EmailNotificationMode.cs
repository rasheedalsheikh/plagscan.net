namespace vn3xt.Plagiarism.PlagScan
{
    using System;

    
    public enum EmailNotificationMode
    {
        Never = 0,

        Always = 1,

        /// <summary>
        /// only if "red" plagiarism level
        /// </summary>
        Red = 2
    }
}
