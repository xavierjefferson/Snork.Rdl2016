using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(Namespace = Constants.Namespace, IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks />
        [XmlEnum("##any:")] Item,

        /// <remarks />
        Source,

        /// <remarks />
        Value
    }
}