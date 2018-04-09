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
    public class NumericIndicatorRangeType
    {
        /// <remarks />
        [XmlElement("DecimalDigitColor", typeof(string))]
        public string DecimalDigitColor { get; set; }

        [XmlElement("DigitColor", typeof(string))]
        public string DigitColor { get; set; }

        [XmlElement("EndValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType EndValue { get; set; }

        [XmlElement("StartValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType StartValue { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}