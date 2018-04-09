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
    public class ChartAxisScaleBreakType
    {
        /// <remarks />
        [XmlElement("BreakLineType", typeof(string))]
        public string BreakLineType { get; set; }

        [XmlElement("CollapsibleSpaceThreshold", typeof(string))]
        public string CollapsibleSpaceThreshold { get; set; }

        [XmlElement("Enabled", typeof(string))]
        public string Enabled { get; set; }

        [XmlElement("IncludeZero", typeof(string))]
        public string IncludeZero { get; set; }

        [XmlElement("MaxNumberOfBreaks", typeof(string))]
        public List<string> MaxNumberOfBreaks { get; set; } = new List<string>();

        [XmlElement("Spacing", typeof(string))]
        public string Spacing { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}