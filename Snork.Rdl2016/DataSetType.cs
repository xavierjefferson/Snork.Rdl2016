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
    public class DataSetType
    {
        /// <remarks />
        [XmlElement("AccentSensitivity", typeof(DataSetTypeAccentSensitivity))]
        public DataSetTypeAccentSensitivity AccentSensitivity { get; set; }

        [XmlElement("CaseSensitivity", typeof(DataSetTypeCaseSensitivity))]
        public DataSetTypeCaseSensitivity CaseSensitivity { get; set; }

        [XmlElement("Collation", typeof(string))]
        public string Collation { get; set; }

        [XmlArray("Fields")]
        [XmlArrayItem("Field", typeof(FieldType))]
        public List<FieldType> Fields { get; set; } = new List<FieldType>();


        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlElement("InterpretSubtotalsAsDetails", typeof(DataSetTypeInterpretSubtotalsAsDetails))]
        public List<DataSetTypeInterpretSubtotalsAsDetails> InterpretSubtotalsAsDetails { get; set; } =
            new List<DataSetTypeInterpretSubtotalsAsDetails>();

        [XmlElement("KanatypeSensitivity", typeof(DataSetTypeKanatypeSensitivity))]
        public DataSetTypeKanatypeSensitivity KanatypeSensitivity { get; set; }

        [XmlElement("Query", typeof(QueryType))]
        public QueryType Query { get; set; }

        [XmlElement("SharedDataSet", typeof(SharedDataSetType))]
        public SharedDataSetType SharedDataSet { get; set; }

        [XmlElement("WidthSensitivity", typeof(DataSetTypeWidthSensitivity))]
        public DataSetTypeWidthSensitivity WidthSensitivity { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}