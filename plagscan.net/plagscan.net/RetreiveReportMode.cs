namespace vn3xt.Plagiarism.PlagScan
{
    using System;

    public enum RetreiveReportMode : byte
    {
        /// <summary>
        /// Retrieve statistics only, such as plagiarism level, number of words, wait etc. (n.b.: wait is in ms, the report timestamp - creation timestamp, so a negative value indicates that the analysis has not started at all or finished yet.)
        /// </summary>
        StatisticsOnly = 0,

        /// <summary>
        /// Retrieve document's plain text and report links; to list of possible plagiarism sources and in-document view of possible plagiarism sources; e.g. https://www.plagscan.com/view?6055
        /// </summary>
        PlainTextAndReportLinks = 1,

        /// <summary>
        /// Retrieve XML with data on all possible plagiarism sources
        /// </summary>
        XML = 2,

        /// <summary>
        /// Retrieve annotated Docx document(if available, depending on user configuration)
        /// </summary>
        AnnotatedDocx = 3,

        /// <summary>
        /// Retrieve HTML document with annotations
        /// </summary>
        HtmlDocumentWithAnnotations = 4,

        /// <summary>
        /// Retrieve HTML report of matches sorted by relevance
        /// </summary>
        HTMLReport = 5,

        /// <summary>
        /// Retrieve new style(interactive) HTML document with annotations
        /// </summary>
        InteractiveHtmlDocumentWithAnnotations = 6,

        /// <summary>
        /// Retrieve latest report type(with formatting and images) - returns URL(link gives temporary access for one hour)
        /// </summary>
        ReportWithFormattingAndImages = 7,

        /// <summary>
        /// PDF version of HTML document with annotations
        /// </summary>
        PdfWithAnnotations = 8,

        /// <summary>
        /// PDF version of HTML report of matches sorted by relevance
        /// </summary>
        PsfReport = 9
    }
}