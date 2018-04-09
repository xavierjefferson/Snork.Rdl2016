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
    public class MapElementViewType
    {
        /// <remarks />
        [XmlElement("LayerName", typeof(string))]
        public string LayerName { get; set; }

        [XmlArray("MapBindingFieldPairs")]
        [XmlArrayItem("MapBindingFieldPair", typeof(MapBindingFieldPairType))]
        public List<MapBindingFieldPairType> MapBindingFieldPairs { get; set; } = new List<MapBindingFieldPairType>();


        [XmlElement("Zoom", typeof(string))]
        public string Zoom { get; set; }
    }
}
