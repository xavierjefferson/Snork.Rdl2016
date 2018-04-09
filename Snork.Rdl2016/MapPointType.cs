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
    public class MapPointType
    {
        /// <remarks />
        [XmlArray("MapFields")]
        [XmlArrayItem("MapField", typeof(MapFieldType))]
        public List<MapFieldType> MapFields { get; set; } = new List<MapFieldType>();

        [XmlElement("MapMarkerTemplate", typeof(MapMarkerTemplateType))]
        public MapMarkerTemplateType MapMarkerTemplate { get; set; }

        [XmlElement("UseCustomPointTemplate", typeof(string))]
        public string UseCustomPointTemplate { get; set; }

        [XmlElement("VectorData", typeof(string))]
        public string VectorData { get; set; }
    }
}