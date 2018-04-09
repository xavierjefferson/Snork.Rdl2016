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
    public class ChartDataPointValuesType
    {
        /// <remarks />
        [XmlElement("End", typeof(string))]
        public string End { get; set; }

        [XmlElement("High", typeof(string))]
        public string High { get; set; }

        [XmlElement("Low", typeof(string))]
        public string Low { get; set; }

        [XmlElement("Mean", typeof(string))]
        public string Mean { get; set; }

        [XmlElement("Median", typeof(string))]
        public string Median { get; set; }

        [XmlElement("Size", typeof(string))]
        public string Size { get; set; }

        [XmlElement("Start", typeof(string))]
        public string Start { get; set; }

        [XmlElement("X", typeof(string))]
        public string X { get; set; }

        [XmlElement("Y", typeof(string))]
        public string Y { get; set; }
    }
}