using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Constants.Namespace)]
    public enum FilterTypeOperator
    {
        /// <remarks />
        Equal,

        /// <remarks />
        Like,

        /// <remarks />
        NotEqual,

        /// <remarks />
        GreaterThan,

        /// <remarks />
        GreaterThanOrEqual,

        /// <remarks />
        LessThan,

        /// <remarks />
        LessThanOrEqual,

        /// <remarks />
        TopN,

        /// <remarks />
        BottomN,

        /// <remarks />
        TopPercent,

        /// <remarks />
        BottomPercent,

        /// <remarks />
        In,

        /// <remarks />
        Between
    }
}