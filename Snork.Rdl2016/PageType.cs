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
    public class PageType
    {
        /// <remarks />
        [XmlElement("Columns", typeof(int))]
        public List<int> Columns { get; set; } = new List<int>();

        [XmlElement("PageFooter", typeof(PageSectionType))]
        public PageSectionType PageFooter { get; set; }

        [XmlElement("PageHeader", typeof(PageSectionType))]
        public PageSectionType PageHeader { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}