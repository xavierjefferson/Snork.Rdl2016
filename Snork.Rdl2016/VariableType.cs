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
    public class VariableType
    {
        /// <remarks />
        [XmlElement("Value", typeof(StringWithDataTypeAttribute))]
        public StringWithDataTypeAttribute Value { get; set; }

        [XmlElement("Writable", typeof(bool))]
        public bool Writable { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}