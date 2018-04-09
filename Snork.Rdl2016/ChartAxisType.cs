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
    public class ChartAxisType
    {
        /// <remarks />
        [XmlElement("AllowLabelRotation", typeof(string))]
        public string AllowLabelRotation { get; set; }

        [XmlElement("Angle", typeof(string))]
        public string Angle { get; set; }

        [XmlElement("Arrows", typeof(string))]
        public List<string> Arrows { get; set; } = new List<string>();

        [XmlElement("ChartAxisScaleBreak", typeof(ChartAxisScaleBreakType))]
        public ChartAxisScaleBreakType ChartAxisScaleBreak { get; set; }

        [XmlElement("ChartAxisTitle", typeof(ChartAxisTitleType))]
        public ChartAxisTitleType ChartAxisTitle { get; set; }

        [XmlElement("ChartMajorGridLines", typeof(ChartGridLinesType))]
        public List<ChartGridLinesType> ChartMajorGridLines { get; set; } = new List<ChartGridLinesType>();

        [XmlElement("ChartMajorTickMarks", typeof(ChartTickMarksType))]
        public List<ChartTickMarksType> ChartMajorTickMarks { get; set; } = new List<ChartTickMarksType>();

        [XmlElement("ChartMinorGridLines", typeof(ChartGridLinesType))]
        public List<ChartGridLinesType> ChartMinorGridLines { get; set; } = new List<ChartGridLinesType>();

        [XmlElement("ChartMinorTickMarks", typeof(ChartTickMarksType))]
        public List<ChartTickMarksType> ChartMinorTickMarks { get; set; } = new List<ChartTickMarksType>();

        [XmlArray("ChartStripLines")]
        [XmlArrayItem("ChartStripLine", typeof(ChartStripLineType))]
        public List<ChartStripLineType> ChartStripLines { get; set; } = new List<ChartStripLineType>();


        [XmlElement("CrossAt", typeof(string))]
        public string CrossAt { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("HideEndLabels", typeof(string))]
        public List<string> HideEndLabels { get; set; } = new List<string>();

        [XmlElement("HideLabels", typeof(string))]
        public List<string> HideLabels { get; set; } = new List<string>();

        [XmlElement("IncludeZero", typeof(string))]
        public string IncludeZero { get; set; }

        [XmlElement("Interlaced", typeof(string))]
        public string Interlaced { get; set; }

        [XmlElement("InterlacedColor", typeof(string))]
        public string InterlacedColor { get; set; }

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("IntervalOffset", typeof(string))]
        public string IntervalOffset { get; set; }

        [XmlElement("IntervalOffsetType", typeof(string))]
        public string IntervalOffsetType { get; set; }

        [XmlElement("IntervalType", typeof(string))]
        public string IntervalType { get; set; }

        [XmlElement("LabelInterval", typeof(string))]
        public string LabelInterval { get; set; }

        [XmlElement("LabelIntervalOffset", typeof(string))]
        public string LabelIntervalOffset { get; set; }

        [XmlElement("LabelIntervalOffsetType", typeof(string))]
        public string LabelIntervalOffsetType { get; set; }

        [XmlElement("LabelIntervalType", typeof(string))]
        public string LabelIntervalType { get; set; }

        [XmlElement("LabelsAutoFitDisabled", typeof(string))]
        public string LabelsAutoFitDisabled { get; set; }

        [XmlElement("Location", typeof(string))]
        public string Location { get; set; }

        [XmlElement("LogBase", typeof(string))]
        public string LogBase { get; set; }

        [XmlElement("LogScale", typeof(string))]
        public string LogScale { get; set; }

        [XmlElement("Margin", typeof(string))]
        public string Margin { get; set; }

        [XmlElement("MarksAlwaysAtPlotEdge", typeof(string))]
        public string MarksAlwaysAtPlotEdge { get; set; }

        [XmlElement("MaxFontSize", typeof(string))]
        public string MaxFontSize { get; set; }

        [XmlElement("Maximum", typeof(string))]
        public string Maximum { get; set; }

        [XmlElement("MinFontSize", typeof(string))]
        public string MinFontSize { get; set; }

        [XmlElement("Minimum", typeof(string))]
        public string Minimum { get; set; }

        [XmlElement("OffsetLabels", typeof(string))]
        public List<string> OffsetLabels { get; set; } = new List<string>();

        [XmlElement("PreventFontGrow", typeof(string))]
        public string PreventFontGrow { get; set; }

        [XmlElement("PreventFontShrink", typeof(string))]
        public string PreventFontShrink { get; set; }

        [XmlElement("PreventLabelOffset", typeof(string))]
        public string PreventLabelOffset { get; set; }

        [XmlElement("PreventWordWrap", typeof(string))]
        public string PreventWordWrap { get; set; }

        [XmlElement("Reverse", typeof(string))]
        public string Reverse { get; set; }

        [XmlElement("Scalar", typeof(bool))]
        public bool Scalar { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("VariableAutoInterval", typeof(string))]
        public string VariableAutoInterval { get; set; }

        [XmlElement("Visible", typeof(string))]
        public string Visible { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
