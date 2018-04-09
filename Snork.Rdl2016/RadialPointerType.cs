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
    public class RadialPointerType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("BarStart", typeof(string))]
        public string BarStart { get; set; }

        [XmlElement("DistanceFromScale", typeof(string))]
        public string DistanceFromScale { get; set; }

        [XmlElement("GaugeInputValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType GaugeInputValue { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("MarkerLength", typeof(string))]
        public string MarkerLength { get; set; }

        [XmlElement("MarkerStyle", typeof(string))]
        public string MarkerStyle { get; set; }

        [XmlElement("NeedleStyle", typeof(string))]
        public string NeedleStyle { get; set; }

        [XmlElement("Placement", typeof(string))]
        public string Placement { get; set; }

        [XmlElement("PointerCap", typeof(PointerCapType))]
        public PointerCapType PointerCap { get; set; }

        [XmlElement("PointerImage", typeof(PointerImageType))]
        public PointerImageType PointerImage { get; set; }

        [XmlElement("SnappingEnabled", typeof(string))]
        public string SnappingEnabled { get; set; }

        [XmlElement("SnappingInterval", typeof(string))]
        public string SnappingInterval { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Type", typeof(string))]
        public string Type { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}