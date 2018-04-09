using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Snork.Rdl2016
{
    /// <remarks />
    [GeneratedCode("xsd", "4.6.1055.0")]
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Constants.Namespace)]
    public enum TextboxTypeDataElementOutput
    {
        /// <remarks />
        Output,

        /// <remarks />
        NoOutput,

        /// <remarks />
        ContentsOnly,

        /// <remarks />
        Auto
    }
}