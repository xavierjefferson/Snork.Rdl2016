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
    public class ChartLegendType
    {
        /// <remarks />
        [XmlElement("AutoFitTextDisabled", typeof(string))]
        public string AutoFitTextDisabled { get; set; }

        [XmlElement("ChartElementPosition", typeof(ChartElementPositionType))]
        public ChartElementPositionType ChartElementPosition { get; set; }

        [XmlArray("ChartLegendColumns")]
        [XmlArrayItem("ChartLegendColumn", typeof(ChartLegendColumnType))]
        public List<ChartLegendColumnType> ChartLegendColumns { get; set; } = new List<ChartLegendColumnType>();


        [XmlElement("ChartLegendTitle", typeof(ChartLegendTitleType))]
        public ChartLegendTitleType ChartLegendTitle { get; set; }

        [XmlElement("ColumnSeparator", typeof(string))]
        public string ColumnSeparator { get; set; }

        [XmlElement("ColumnSeparatorColor", typeof(string))]
        public string ColumnSeparatorColor { get; set; }

        [XmlElement("ColumnSpacing", typeof(string))]
        public string ColumnSpacing { get; set; }

        [XmlElement("DockOutsideChartArea", typeof(string))]
        public string DockOutsideChartArea { get; set; }

        [XmlElement("DockToChartArea", typeof(string))]
        public string DockToChartArea { get; set; }

        [XmlElement("EquallySpacedItems", typeof(string))]
        public List<string> EquallySpacedItems { get; set; } = new List<string>();

        [XmlElement("HeaderSeparator", typeof(string))]
        public string HeaderSeparator { get; set; }

        [XmlElement("HeaderSeparatorColor", typeof(string))]
        public string HeaderSeparatorColor { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("InterlacedRows", typeof(string))]
        public List<string> InterlacedRows { get; set; } = new List<string>();

        [XmlElement("InterlacedRowsColor", typeof(string))]
        public string InterlacedRowsColor { get; set; }

        [XmlElement("Layout", typeof(string))]
        public string Layout { get; set; }

        [XmlElement("MaxAutoSize", typeof(string))]
        public string MaxAutoSize { get; set; }

        [XmlElement("MinFontSize", typeof(string))]
        public string MinFontSize { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("Reversed", typeof(string))]
        public string Reversed { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextWrapThreshold", typeof(string))]
        public string TextWrapThreshold { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
