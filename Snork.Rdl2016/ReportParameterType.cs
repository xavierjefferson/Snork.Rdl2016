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
    public class ReportParameterType
    {
        /// <remarks />
        [XmlElement("AllowBlank", typeof(bool))]
        public bool AllowBlank { get; set; }

        [XmlElement("DataType", typeof(ReportParameterTypeDataType))]
        public ReportParameterTypeDataType DataType { get; set; }

        [XmlElement("DefaultValue", typeof(DefaultValueType))]
        public DefaultValueType DefaultValue { get; set; }

        [XmlElement("Hidden", typeof(bool))]
        public bool Hidden { get; set; }

        [XmlElement("MultiValue", typeof(bool))]
        public bool MultiValue { get; set; }

        [XmlElement("Nullable", typeof(bool))]
        public bool Nullable { get; set; }

        [XmlElement("Prompt", typeof(StringLocIDType))]
        public StringLocIDType Prompt { get; set; }

        [XmlElement("UsedInQuery", typeof(ReportParameterTypeUsedInQuery))]
        public ReportParameterTypeUsedInQuery UsedInQuery { get; set; }

        [XmlElement("ValidValues", typeof(ValidValuesType))]
        public List<ValidValuesType> ValidValues { get; set; } = new List<ValidValuesType>();


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}