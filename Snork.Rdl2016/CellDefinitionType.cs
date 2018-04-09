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
    public class CellDefinitionType
    {
        /// <remarks />
        [XmlElement("ColumnIndex", typeof(int))]
        public int ColumnIndex { get; set; }

        [XmlElement("ParameterName", typeof(string), DataType = "normalizedString")]
        public string ParameterName { get; set; }

        [XmlElement("RowIndex", typeof(int))]
        public int RowIndex { get; set; }
    }
}