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
    public class GaugeInputValueType
    {
        /// <remarks />
        [XmlElement("AddConstant", typeof(string))]
        public string AddConstant { get; set; }

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(GaugeInputValueTypeDataElementOutput))]
        public GaugeInputValueTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Formula", typeof(string))]
        public string Formula { get; set; }

        [XmlElement("MaxPercent", typeof(string))]
        public string MaxPercent { get; set; }

        [XmlElement("MinPercent", typeof(string))]
        public string MinPercent { get; set; }

        [XmlElement("Multiplier", typeof(string))]
        public string Multiplier { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }
    }
}