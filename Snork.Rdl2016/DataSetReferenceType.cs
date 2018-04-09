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
    public class DataSetReferenceType
    {
        /// <remarks />
        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlElement("LabelField", typeof(string))]
        public string LabelField { get; set; }

        [XmlElement("ValueField", typeof(string))]
        public string ValueField { get; set; }
    }
}