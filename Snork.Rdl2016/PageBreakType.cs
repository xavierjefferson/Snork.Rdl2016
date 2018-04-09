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
    public class PageBreakType
    {
        /// <remarks />
        [XmlElement("BreakLocation", typeof(PageBreakTypeBreakLocation))]
        public PageBreakTypeBreakLocation BreakLocation { get; set; }

        [XmlElement("Disabled", typeof(string))]
        public string Disabled { get; set; }

        [XmlElement("ResetPageNumber", typeof(string))]
        public string ResetPageNumber { get; set; }
    }
}