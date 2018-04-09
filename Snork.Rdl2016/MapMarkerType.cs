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
    public class MapMarkerType
    {
        /// <remarks />
        [XmlElement("MapMarkerImage", typeof(MapMarkerImageType))]
        public MapMarkerImageType MapMarkerImage { get; set; }

        [XmlElement("MapMarkerStyle", typeof(string))]
        public string MapMarkerStyle { get; set; }
    }
}