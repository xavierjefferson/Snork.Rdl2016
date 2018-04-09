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
    public class IndicatorStateType
    {
        /// <remarks />
        [XmlElement("Color", typeof(string))]
        public string Color { get; set; }

        [XmlElement("EndValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType EndValue { get; set; }

        [XmlElement("IndicatorImage", typeof(IndicatorImageType))]
        public IndicatorImageType IndicatorImage { get; set; }

        [XmlElement("IndicatorStyle", typeof(string))]
        public string IndicatorStyle { get; set; }

        [XmlElement("ScaleFactor", typeof(string))]
        public string ScaleFactor { get; set; }

        [XmlElement("StartValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType StartValue { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}