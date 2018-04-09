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
    public class MapPolygonLayerType
    {
        /// <remarks />
        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(MapPolygonLayerTypeDataElementOutput))]
        public MapPolygonLayerTypeDataElementOutput DataElementOutput { get; set; }

        [XmlArray("MapBindingFieldPairs")]
        [XmlArrayItem("MapBindingFieldPair", typeof(MapBindingFieldPairType))]
        public List<MapBindingFieldPairType> MapBindingFieldPairs { get; set; } = new List<MapBindingFieldPairType>();


        [XmlElement("MapCenterPointRules", typeof(MapPointRulesType))]
        public List<MapPointRulesType> MapCenterPointRules { get; set; } = new List<MapPointRulesType>();

        [XmlElement("MapDataRegionName", typeof(string))]
        public string MapDataRegionName { get; set; }

        [XmlArray("MapFieldDefinitions")]
        [XmlArrayItem("MapFieldDefinition", typeof(MapFieldDefinitionType))]
        public List<MapFieldDefinitionType> MapFieldDefinitions { get; set; } = new List<MapFieldDefinitionType>();


        [XmlElement("MapMarkerTemplate", typeof(MapMarkerTemplateType))]
        public MapMarkerTemplateType MapMarkerTemplate { get; set; }

        [XmlElement("MapPolygonRules", typeof(MapPolygonRulesType))]
        public List<MapPolygonRulesType> MapPolygonRules { get; set; } = new List<MapPolygonRulesType>();

        [XmlElement("MapPolygonTemplate", typeof(MapPolygonTemplateType))]
        public MapPolygonTemplateType MapPolygonTemplate { get; set; }

        [XmlArray("MapPolygons")]
        [XmlArrayItem("MapPolygon", typeof(MapPolygonType))]
        public List<MapPolygonType> MapPolygons { get; set; } = new List<MapPolygonType>();


        [XmlElement("MapShapefile", typeof(MapShapefileType))]
        public MapShapefileType MapShapefile { get; set; }

        [XmlElement("MapSpatialDataRegion", typeof(MapSpatialDataRegionType))]
        public MapSpatialDataRegionType MapSpatialDataRegion { get; set; }

        [XmlElement("MapSpatialDataSet", typeof(MapSpatialDataSetType))]
        public MapSpatialDataSetType MapSpatialDataSet { get; set; }

        [XmlElement("MaximumZoom", typeof(string))]
        public string MaximumZoom { get; set; }

        [XmlElement("MinimumZoom", typeof(string))]
        public string MinimumZoom { get; set; }

        [XmlElement("Transparency", typeof(string))]
        public string Transparency { get; set; }

        [XmlElement("VisibilityMode", typeof(string))]
        public string VisibilityMode { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
