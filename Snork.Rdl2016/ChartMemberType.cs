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
    public class ChartMemberType
    {
        /// <remarks />
        [XmlArray("ChartMembers")]
        [XmlArrayItem("ChartMember", typeof(ChartMemberType))]
        public List<ChartMemberType> ChartMembers { get; set; } = new List<ChartMemberType>();


        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(ChartMemberTypeDataElementOutput))]
        public ChartMemberTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Group", typeof(GroupType))]
        public GroupType Group { get; set; }

        [XmlElement("Label", typeof(StringLocIDType))]
        public StringLocIDType Label { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();

    }
}
