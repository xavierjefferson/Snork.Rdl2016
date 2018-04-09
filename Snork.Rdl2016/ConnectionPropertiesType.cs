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
    public class ConnectionPropertiesType
    {
        /// <remarks />
        [XmlElement("ConnectString", typeof(string))]
        public string ConnectString { get; set; }

        [XmlElement("DataProvider", typeof(string))]
        public string DataProvider { get; set; }

        [XmlElement("IntegratedSecurity", typeof(bool))]
        public bool IntegratedSecurity { get; set; }

        [XmlElement("Prompt", typeof(StringLocIDType))]
        public StringLocIDType Prompt { get; set; }
    }
}