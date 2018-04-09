using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = Constants.Namespace)]
    public class ReportSectionType
    {
        /// <remarks />
        [XmlElement("Body", typeof(BodyType))]
        public BodyType Body { get; set; }

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(ReportSectionTypeDataElementOutput))]
        public ReportSectionTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Page", typeof(PageType))]
        public PageType Page { get; set; }
    }
}