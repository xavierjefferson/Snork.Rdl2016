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
    public class DataSourceType
    {
        /// <remarks />
        [XmlElement("ConnectionProperties", typeof(ConnectionPropertiesType))]
        public List<ConnectionPropertiesType> ConnectionProperties { get; set; } = new List<ConnectionPropertiesType>();

        [XmlElement("DataSourceReference", typeof(string))]
        public string DataSourceReference { get; set; }

        [XmlElement("Transaction", typeof(bool))]
        public bool Transaction { get; set; }


        /// <remarks />
        [XmlAttribute]
        public string Name { get; set; }
    }
}