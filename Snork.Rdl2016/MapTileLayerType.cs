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
    public class MapTileLayerType
    {
        /// <remarks />
        [XmlArray("MapTiles")]
        [XmlArrayItem("MapTile", typeof(MapTileType))]
        public List<MapTileType> MapTiles { get; set; } = new List<MapTileType>();


        [XmlElement("MaximumZoom", typeof(string))]
        public string MaximumZoom { get; set; }

        [XmlElement("MinimumZoom", typeof(string))]
        public string MinimumZoom { get; set; }

        [XmlElement("TileStyle", typeof(string))]
        public string TileStyle { get; set; }

        [XmlElement("Transparency", typeof(string))]
        public string Transparency { get; set; }

        [XmlElement("UseSecureConnection", typeof(string))]
        public string UseSecureConnection { get; set; }

        [XmlElement("VisibilityMode", typeof(string))]
        public string VisibilityMode { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
