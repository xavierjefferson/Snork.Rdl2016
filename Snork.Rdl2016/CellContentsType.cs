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
    public class CellContentsType
    {
        /// <remarks />
        [XmlElement("Chart", typeof(ChartType))]
        public ChartType Chart { get; set; }

        [XmlElement("ColSpan", typeof(uint))]
        public uint ColSpan { get; set; }

        [XmlElement("CustomReportItem", typeof(CustomReportItemType))]
        public CustomReportItemType CustomReportItem { get; set; }

        [XmlElement("GaugePanel", typeof(GaugePanelType))]
        public GaugePanelType GaugePanel { get; set; }

        [XmlElement("Image", typeof(ImageType))]
        public ImageType Image { get; set; }

        [XmlElement("Line", typeof(LineType))]
        public LineType Line { get; set; }

        [XmlElement("Map", typeof(MapType))]
        public MapType Map { get; set; }

        [XmlElement("Rectangle", typeof(RectangleType))]
        public RectangleType Rectangle { get; set; }

        [XmlElement("RowSpan", typeof(uint))]
        public uint RowSpan { get; set; }

        [XmlElement("Subreport", typeof(SubreportType))]
        public SubreportType Subreport { get; set; }

        [XmlElement("Tablix", typeof(TablixType))]
        public TablixType Tablix { get; set; }

        [XmlElement("Textbox", typeof(TextboxType))]
        public TextboxType Textbox { get; set; }
    }
}