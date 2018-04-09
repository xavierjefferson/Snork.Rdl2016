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
    public class DefaultValueType
    {
        /// <remarks />
        [XmlElement("DataSetReference", typeof(DataSetReferenceType))]
        public DataSetReferenceType DataSetReference { get; set; }

        [XmlElement("Values", typeof(ValuesType))]
        public List<ValuesType> Values { get; set; } = new List<ValuesType>();
    }
}