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
    public class MapType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("AntiAliasing", typeof(string))]
        public string AntiAliasing { get; set; }

        [XmlElement("Bookmark", typeof(string))]
        public string Bookmark { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(object))]
        public object DataElementOutput { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlElement("MapBorderSkin", typeof(MapBorderSkinType_))]
        public MapBorderSkinType_ MapBorderSkin { get; set; }

        [XmlElement("MapColorScale", typeof(MapColorScaleType))]
        public MapColorScaleType MapColorScale { get; set; }

        [XmlArray("MapDataRegions")]
        [XmlArrayItem("MapDataRegion", typeof(MapDataRegionType))]
        public List<MapDataRegionType> MapDataRegions { get; set; } = new List<MapDataRegionType>();


        [XmlElement("MapDistanceScale", typeof(MapDistanceScaleType))]
        public MapDistanceScaleType MapDistanceScale { get; set; }

        [XmlElement("MapLayers", typeof(MapLayersType))]
        public List<MapLayersType> MapLayers { get; set; } = new List<MapLayersType>();

        [XmlArray("MapLegends")]
        [XmlArrayItem("MapLegend", typeof(MapLegendType))]
        public List<MapLegendType> MapLegends { get; set; } = new List<MapLegendType>();


        [XmlArray("MapTitles")]
        [XmlArrayItem("MapTitle", typeof(MapTitleType))]
        public List<MapTitleType> MapTitles { get; set; } = new List<MapTitleType>();


        [XmlElement("MapViewport", typeof(MapViewportType))]
        public MapViewportType MapViewport { get; set; }

        [XmlElement("MaximumSpatialElementCount", typeof(uint))]
        public uint MaximumSpatialElementCount { get; set; }

        [XmlElement("MaximumTotalPointCount", typeof(uint))]
        public uint MaximumTotalPointCount { get; set; }

        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlElement("ShadowIntensity", typeof(string))]
        public string ShadowIntensity { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextAntiAliasingQuality", typeof(string))]
        public string TextAntiAliasingQuality { get; set; }

        [XmlElement("TileLanguage", typeof(string))]
        public string TileLanguage { get; set; }

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
