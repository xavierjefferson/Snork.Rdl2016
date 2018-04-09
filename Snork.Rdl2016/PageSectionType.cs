using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
    public class PageSectionType
    {
        /// <remarks />
        [XmlElement("PrintBetweenSections", typeof(bool))]
        public List<bool> PrintBetweenSections { get; set; } = new List<bool>();

        [XmlElement("PrintOnFirstPage", typeof(bool))]
        public bool PrintOnFirstPage { get; set; }

        [XmlElement("PrintOnLastPage", typeof(bool))]
        public bool PrintOnLastPage { get; set; }

        [XmlElement("ReportItems", typeof(ReportItemsType))]
        public List<ReportItemsType> ReportItems { get; set; } = new List<ReportItemsType>();

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}