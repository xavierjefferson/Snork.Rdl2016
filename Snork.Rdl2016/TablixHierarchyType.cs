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
    public class TablixHierarchyType
    {
        /// <remarks />
        [XmlArray("TablixMembers")]
        [XmlArrayItem("TablixMember", typeof(TablixMemberType))]
        public List<TablixMemberType> TablixMembers { get; set; } = new List<TablixMemberType>();
    }
}