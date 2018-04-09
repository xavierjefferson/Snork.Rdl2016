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
    public class CustomDataType
    {
        /// <remarks />
        [XmlElement("DataColumnHierarchy", typeof(DataColumnHierarchyType))]
        public DataColumnHierarchyType DataColumnHierarchy { get; set; }

        [XmlElement("DataRowHierarchy", typeof(DataRowHierarchyType))]
        public DataRowHierarchyType DataRowHierarchy { get; set; }

        [XmlArray("DataRows")]
        [XmlArrayItem("DataRow", typeof(DataRowType))]
        public List<DataRowType> DataRows { get; set; } = new List<DataRowType>();


        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();

    }
}
