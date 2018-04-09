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
    public class ChartLegendCustomItemCellType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Alignment", typeof(string))]
        public string Alignment { get; set; }

        [XmlElement("BottomMargin", typeof(string))]
        public string BottomMargin { get; set; }

        [XmlElement("CellSpan", typeof(uint))]
        public uint CellSpan { get; set; }

        [XmlElement("CellType", typeof(ChartLegendCustomItemCellTypeCellType))]
        public ChartLegendCustomItemCellTypeCellType CellType { get; set; }

        [XmlElement("ImageHeight", typeof(string))]
        public string ImageHeight { get; set; }

        [XmlElement("ImageWidth", typeof(string))]
        public string ImageWidth { get; set; }

        [XmlElement("LeftMargin", typeof(string))]
        public string LeftMargin { get; set; }

        [XmlElement("RightMargin", typeof(string))]
        public string RightMargin { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("SymbolHeight", typeof(string))]
        public string SymbolHeight { get; set; }

        [XmlElement("SymbolWidth", typeof(string))]
        public string SymbolWidth { get; set; }

        [XmlElement("Text", typeof(string))]
        public string Text { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("TopMargin", typeof(string))]
        public string TopMargin { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}