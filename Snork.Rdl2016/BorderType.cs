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
    public class BorderType
    {
        /// <remarks />
        [XmlElement("Color", typeof(string))]
        public string Color { get; set; }

        [XmlElement("Style", typeof(string))]
        public string Style { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }
    }
}