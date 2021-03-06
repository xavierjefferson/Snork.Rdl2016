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
    public class MapSpatialDataSetType
    {
        /// <remarks />
        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlElement("MapFieldNames", typeof(MapFieldNamesType))]
        public List<MapFieldNamesType> MapFieldNames { get; set; } = new List<MapFieldNamesType>();

        [XmlElement("SpatialField", typeof(string))]
        public string SpatialField { get; set; }
    }
}