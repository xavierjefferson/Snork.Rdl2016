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
    public class ParameterType
    {
        /// <remarks />
        [XmlElement("Omit", typeof(string))]
        public string Omit { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }


        /// <remarks />
        [XmlAttribute]
        public string Name { get; set; }
    }
}