using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Constants.Namespace)]
    public enum PageBreakTypeBreakLocation
    {
        /// <remarks />
        None,

        /// <remarks />
        Start,

        /// <remarks />
        End,

        /// <remarks />
        StartAndEnd,

        /// <remarks />
        Between
    }
}