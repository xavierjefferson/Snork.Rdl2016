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
    public class MapViewportType
    {
        /// <remarks />
        [XmlElement("BottomMargin", typeof(string))]
        public string BottomMargin { get; set; }

        [XmlElement("ContentMargin", typeof(string))]
        public string ContentMargin { get; set; }

        [XmlElement("GridUnderContent", typeof(string))]
        public string GridUnderContent { get; set; }

        [XmlElement("LeftMargin", typeof(string))]
        public string LeftMargin { get; set; }

        [XmlElement("MapCoordinateSystem", typeof(string))]
        public string MapCoordinateSystem { get; set; }

        [XmlElement("MapCustomView", typeof(MapCustomViewType))]
        public MapCustomViewType MapCustomView { get; set; }

        [XmlElement("MapDataBoundView", typeof(MapDataBoundViewType))]
        public MapDataBoundViewType MapDataBoundView { get; set; }

        [XmlElement("MapElementView", typeof(MapElementViewType))]
        public MapElementViewType MapElementView { get; set; }

        [XmlElement("MapLimits", typeof(MapLimitsType))]
        public List<MapLimitsType> MapLimits { get; set; } = new List<MapLimitsType>();

        [XmlElement("MapLocation", typeof(MapLocationType))]
        public MapLocationType MapLocation { get; set; }

        [XmlElement("MapMeridians", typeof(MapGridLinesType))]
        public List<MapGridLinesType> MapMeridians { get; set; } = new List<MapGridLinesType>();

        [XmlElement("MapParallels", typeof(MapGridLinesType))]
        public List<MapGridLinesType> MapParallels { get; set; } = new List<MapGridLinesType>();

        [XmlElement("MapProjection", typeof(string))]
        public string MapProjection { get; set; }

        [XmlElement("MapSize", typeof(MapSizeType))]
        public MapSizeType MapSize { get; set; }

        [XmlElement("MaximumZoom", typeof(string))]
        public string MaximumZoom { get; set; }

        [XmlElement("MinimumZoom", typeof(string))]
        public string MinimumZoom { get; set; }

        [XmlElement("ProjectionCenterX", typeof(string))]
        public string ProjectionCenterX { get; set; }

        [XmlElement("ProjectionCenterY", typeof(string))]
        public string ProjectionCenterY { get; set; }

        [XmlElement("RightMargin", typeof(string))]
        public string RightMargin { get; set; }

        [XmlElement("SimplificationResolution", typeof(string))]
        public string SimplificationResolution { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TopMargin", typeof(string))]
        public string TopMargin { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }
    }
}