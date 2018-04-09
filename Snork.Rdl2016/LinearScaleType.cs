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
    public class LinearScaleType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlArray("CustomLabels")]
        [XmlArrayItem("CustomLabel", typeof(CustomLabelType))]
        public List<CustomLabelType> CustomLabels { get; set; } = new List<CustomLabelType>();


        [XmlElement("EndMargin", typeof(string))]
        public string EndMargin { get; set; }

        [XmlElement("GaugeMajorTickMarks", typeof(GaugeTickMarksType))]
        public List<GaugeTickMarksType> GaugeMajorTickMarks { get; set; } = new List<GaugeTickMarksType>();

        [XmlElement("GaugeMinorTickMarks", typeof(GaugeTickMarksType))]
        public List<GaugeTickMarksType> GaugeMinorTickMarks { get; set; } = new List<GaugeTickMarksType>();

        [XmlArray("GaugePointers")]
        [XmlArrayItem("LinearPointer", typeof(LinearPointerType))]
        public List<LinearPointerType> GaugePointers { get; set; } = new List<LinearPointerType>();

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("IntervalOffset", typeof(string))]
        public string IntervalOffset { get; set; }

        [XmlElement("Logarithmic", typeof(string))]
        public string Logarithmic { get; set; }

        [XmlElement("LogarithmicBase", typeof(string))]
        public string LogarithmicBase { get; set; }

        [XmlElement("MaximumPin", typeof(ScalePinType))]
        public ScalePinType MaximumPin { get; set; }

        [XmlElement("MaximumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MaximumValue { get; set; }

        [XmlElement("MinimumPin", typeof(ScalePinType))]
        public ScalePinType MinimumPin { get; set; }

        [XmlElement("MinimumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MinimumValue { get; set; }

        [XmlElement("Multiplier", typeof(string))]
        public string Multiplier { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("Reversed", typeof(string))]
        public string Reversed { get; set; }

        [XmlElement("ScaleLabels", typeof(ScaleLabelsType))]
        public List<ScaleLabelsType> ScaleLabels { get; set; } = new List<ScaleLabelsType>();

        [XmlArray("ScaleRanges")]
        [XmlArrayItem("ScaleRange", typeof(ScaleRangeType))]
        public List<ScaleRangeType> ScaleRanges { get; set; } = new List<ScaleRangeType>();


        [XmlElement("StartMargin", typeof(string))]
        public string StartMargin { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TickMarksOnTop", typeof(string))]
        public string TickMarksOnTop { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}