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
    public class MapLayersType
    {
        /// <remarks />
        [XmlElement("MapLineLayer", typeof(MapLineLayerType))]
        [XmlElement("MapPointLayer", typeof(MapPointLayerType))]
        [XmlElement("MapPolygonLayer", typeof(MapPolygonLayerType))]
        [XmlElement("MapTileLayer", typeof(MapTileLayerType))]
        public List<object> Items { get; set; }
    }
}