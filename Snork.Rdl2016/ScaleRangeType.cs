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
    public class ScaleRangeType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("BackgroundGradientType", typeof(string))]
        public string BackgroundGradientType { get; set; }

        [XmlElement("DistanceFromScale", typeof(string))]
        public string DistanceFromScale { get; set; }

        [XmlElement("EndValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType EndValue { get; set; }

        [XmlElement("EndWidth", typeof(string))]
        public string EndWidth { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("InRangeBarPointerColor", typeof(string))]
        public string InRangeBarPointerColor { get; set; }

        [XmlElement("InRangeLabelColor", typeof(string))]
        public string InRangeLabelColor { get; set; }

        [XmlElement("InRangeTickMarksColor", typeof(string))]
        public string InRangeTickMarksColor { get; set; }

        [XmlElement("Placement", typeof(string))]
        public string Placement { get; set; }

        [XmlElement("StartValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType StartValue { get; set; }

        [XmlElement("StartWidth", typeof(string))]
        public string StartWidth { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}