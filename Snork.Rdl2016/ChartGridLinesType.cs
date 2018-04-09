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
    public class ChartGridLinesType
    {
        /// <remarks />
        [XmlElement("Enabled", typeof(string))]
        public string Enabled { get; set; }

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("IntervalOffset", typeof(string))]
        public string IntervalOffset { get; set; }

        [XmlElement("IntervalOffsetType", typeof(string))]
        public string IntervalOffsetType { get; set; }

        [XmlElement("IntervalType", typeof(string))]
        public string IntervalType { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}