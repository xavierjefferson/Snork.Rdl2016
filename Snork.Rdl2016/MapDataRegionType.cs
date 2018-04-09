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
    public class MapDataRegionType
    {
        /// <remarks />
        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlElement("MapMember", typeof(MapMemberType))]
        public MapMemberType MapMember { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}