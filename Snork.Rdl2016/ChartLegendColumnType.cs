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
    public class ChartLegendColumnType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("ColumnType", typeof(ChartLegendColumnTypeColumnType))]
        public ChartLegendColumnTypeColumnType ColumnType { get; set; }

        [XmlElement("MaximumWidth", typeof(string))]
        public string MaximumWidth { get; set; }

        [XmlElement("MinimumWidth", typeof(string))]
        public string MinimumWidth { get; set; }

        [XmlElement("SeriesSymbolHeight", typeof(string))]
        public string SeriesSymbolHeight { get; set; }

        [XmlElement("SeriesSymbolWidth", typeof(string))]
        public string SeriesSymbolWidth { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}