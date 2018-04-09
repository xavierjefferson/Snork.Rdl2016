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
    public class NumericIndicatorType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("DecimalDigitColor", typeof(string))]
        public string DecimalDigitColor { get; set; }

        [XmlElement("DecimalDigits", typeof(string))]
        public List<string> DecimalDigits { get; set; } = new List<string>();

        [XmlElement("DigitColor", typeof(string))]
        public string DigitColor { get; set; }

        [XmlElement("Digits", typeof(string))]
        public List<string> Digits { get; set; } = new List<string>();

        [XmlElement("GaugeInputValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType GaugeInputValue { get; set; }

        [XmlElement("Height", typeof(string))]
        public string Height { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("IndicatorStyle", typeof(string))]
        public string IndicatorStyle { get; set; }

        [XmlElement("LedDimColor", typeof(string))]
        public string LedDimColor { get; set; }

        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("MaximumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MaximumValue { get; set; }

        [XmlElement("MinimumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MinimumValue { get; set; }

        [XmlElement("Multiplier", typeof(string))]
        public string Multiplier { get; set; }

        [XmlArray("NumericIndicatorRanges")]
        [XmlArrayItem("NumericIndicatorRange", typeof(NumericIndicatorRangeType))]
        public List<NumericIndicatorRangeType> NumericIndicatorRanges { get; set; } = new List<NumericIndicatorRangeType>();

           

        [XmlElement("OffString", typeof(string))]
        public string OffString { get; set; }

        [XmlElement("OutOfRangeString", typeof(string))]
        public string OutOfRangeString { get; set; }

        [XmlElement("ParentItem", typeof(string))]
        public string ParentItem { get; set; }

        [XmlElement("ResizeMode", typeof(string))]
        public string ResizeMode { get; set; }

        [XmlElement("SeparatorColor", typeof(string))]
        public string SeparatorColor { get; set; }

        [XmlElement("SeparatorWidth", typeof(string))]
        public string SeparatorWidth { get; set; }

        [XmlElement("ShowDecimalPoint", typeof(string))]
        public string ShowDecimalPoint { get; set; }

        [XmlElement("ShowLeadingZeros", typeof(string))]
        public List<string> ShowLeadingZeros { get; set; } = new List<string>();

        [XmlElement("ShowSign", typeof(string))]
        public string ShowSign { get; set; }

        [XmlElement("SnappingEnabled", typeof(string))]
        public string SnappingEnabled { get; set; }

        [XmlElement("SnappingInterval", typeof(string))]
        public string SnappingInterval { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("UseFontPercent", typeof(string))]
        public string UseFontPercent { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
