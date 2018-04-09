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
    public class ChartType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Bookmark", typeof(string))]
        public string Bookmark { get; set; }

        [XmlArray("ChartAreas")]
        [XmlArrayItem("ChartArea", typeof(ChartAreaType))]
        public List<ChartAreaType> ChartAreas { get; set; } = new List<ChartAreaType>();


        [XmlElement("ChartBorderSkin", typeof(ChartBorderSkinType_))]
        public ChartBorderSkinType_ ChartBorderSkin { get; set; }

        [XmlElement("ChartCategoryHierarchy", typeof(ChartHierarchyType))]
        public ChartHierarchyType ChartCategoryHierarchy { get; set; }

        [XmlElement("ChartCustomPaletteColors", typeof(ChartCustomPaletteColorsType))]
        public List<ChartCustomPaletteColorsType> ChartCustomPaletteColors { get; set; } =
            new List<ChartCustomPaletteColorsType>();

        [XmlElement("ChartData", typeof(ChartDataType))]
        public ChartDataType ChartData { get; set; }

        [XmlArray("ChartLegends")]
        [XmlArrayItem("ChartLegend", typeof(ChartLegendType))]
        public List<ChartLegendType> ChartLegends { get; set; } = new List<ChartLegendType>();


        [XmlElement("ChartNoDataMessage", typeof(ChartTitleType))]
        public ChartTitleType ChartNoDataMessage { get; set; }

        [XmlElement("ChartSeriesHierarchy", typeof(ChartHierarchyType))]
        public ChartHierarchyType ChartSeriesHierarchy { get; set; }

        [XmlArray("ChartTitles")]
        [XmlArrayItem("ChartTitle", typeof(ChartTitleType))]
        public List<ChartTitleType> ChartTitles { get; set; } = new List<ChartTitleType>();


        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(ChartTypeDataElementOutput))]
        public ChartTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlElement("DynamicHeight", typeof(string))]
        public string DynamicHeight { get; set; }

        [XmlElement("DynamicWidth", typeof(string))]
        public string DynamicWidth { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlElement("NoRowsMessage", typeof(string))]
        public string NoRowsMessage { get; set; }

        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlElement("Palette", typeof(string))]
        public string Palette { get; set; }

        [XmlElement("PaletteHatchBehavior", typeof(string))]
        public string PaletteHatchBehavior { get; set; }

        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();


        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("Visibility", typeof(VisibilityType))]
        public VisibilityType Visibility { get; set; }

        [XmlElement("ZIndex", typeof(uint))]
        public uint ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
