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
    public class UserSortType
    {
        /// <remarks />
        [XmlElement("SortExpression", typeof(string))]
        public string SortExpression { get; set; }

        [XmlElement("SortExpressionScope", typeof(string))]
        public string SortExpressionScope { get; set; }

        [XmlElement("SortTarget", typeof(string))]
        public string SortTarget { get; set; }
    }
}