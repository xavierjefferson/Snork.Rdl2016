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
    public class GroupType
    {
        /// <remarks />
        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(GroupTypeDataElementOutput))]
        public GroupTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlElement("DomainScope", typeof(string))]
        public string DomainScope { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlElement("GroupExpressions", typeof(GroupExpressionsType))]
        public List<GroupExpressionsType> GroupExpressions { get; set; } = new List<GroupExpressionsType>();

        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlElement("Parent", typeof(string))]
        public string Parent { get; set; }

        [XmlElement("ReGroupExpressions", typeof(GroupExpressionsType))]
        public List<GroupExpressionsType> ReGroupExpressions { get; set; } = new List<GroupExpressionsType>();

        [XmlArray("Variables")]
        [XmlArrayItem("Variable", typeof(VariableType))]
        public List<VariableType> Variables { get; set; } = new List<VariableType>();


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}