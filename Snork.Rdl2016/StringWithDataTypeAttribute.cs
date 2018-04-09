using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [XmlInclude(typeof(LocIDStringWithDataTypeAttribute))]
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = Constants.Namespace)]
    public class StringWithDataTypeAttribute
    {
        /// <remarks />
        [XmlAttribute]
        public StringWithDataTypeAttributeDataType DataType { get; set; }

        /// <remarks />
        [XmlIgnore]
        public bool DataTypeSpecified { get; set; }


        /// <remarks />
        [XmlText]
        public string Value { get; set; }
    }
}