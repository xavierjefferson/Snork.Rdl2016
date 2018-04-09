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
    public class TablixMemberType
    {
        /// <remarks />
        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(TablixMemberTypeDataElementOutput))]
        public TablixMemberTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("FixedData", typeof(bool))]
        public bool FixedData { get; set; }

        [XmlElement("Group", typeof(GroupType))]
        public GroupType Group { get; set; }

        [XmlElement("HideIfNoRows", typeof(bool))]
        public List<bool> HideIfNoRows { get; set; } = new List<bool>();

        [XmlElement("KeepTogether", typeof(bool))]
        public bool KeepTogether { get; set; }

        [XmlElement("KeepWithGroup", typeof(TablixMemberTypeKeepWithGroup))]
        public TablixMemberTypeKeepWithGroup KeepWithGroup { get; set; }

        [XmlElement("RepeatOnNewPage", typeof(bool))]
        public bool RepeatOnNewPage { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();


        [XmlElement("TablixHeader", typeof(TablixHeaderType))]
        public TablixHeaderType TablixHeader { get; set; }

        [XmlArray("TablixMembers")]
        [XmlArrayItem("TablixMember", typeof(TablixMemberType))]
        public List<TablixMemberType> TablixMembers { get; set; } = new List<TablixMemberType>();


        [XmlElement("Visibility", typeof(VisibilityType))]
        public VisibilityType Visibility { get; set; }
    }
}
