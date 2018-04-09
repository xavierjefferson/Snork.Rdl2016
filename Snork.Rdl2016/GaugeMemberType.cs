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
    public class GaugeMemberType
    {
        /// <remarks />
        [XmlElement("GaugeMember", typeof(GaugeMemberType))]
        public GaugeMemberType GaugeMember { get; set; }

        [XmlElement("Group", typeof(GroupType))]
        public GroupType Group { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();
    }
}