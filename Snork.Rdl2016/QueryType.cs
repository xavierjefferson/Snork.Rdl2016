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
    public class QueryType
    {
        /// <remarks />
        [XmlElement("CommandText", typeof(string))]
        public string CommandText { get; set; }

        [XmlElement("CommandType", typeof(QueryTypeCommandType))]
        public QueryTypeCommandType CommandType { get; set; }

        [XmlElement("DataSourceName", typeof(string))]
        public string DataSourceName { get; set; }

        [XmlArray("QueryParameters")]
        [XmlArrayItem("QueryParameter", typeof(QueryParameterType))]
        public List<QueryParameterType> QueryParameters { get; set; } = new List<QueryParameterType>();


        [XmlElement("Timeout", typeof(uint))]
        public uint Timeout { get; set; }
    }
}