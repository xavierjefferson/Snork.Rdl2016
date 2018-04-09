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
    public class DataColumnHierarchyType
    {
        /// <remarks />
        [XmlArray("DataMembers")]
        [XmlArrayItem("DataMember", typeof(DataMemberType))]
        public List<DataMemberType> DataMembers { get; set; } = new List<DataMemberType>();
    }
}