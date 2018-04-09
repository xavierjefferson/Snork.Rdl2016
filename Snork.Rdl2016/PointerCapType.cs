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
    public class PointerCapType
    {
        /// <remarks />
        [XmlElement("CapImage", typeof(CapImageType))]
        public CapImageType CapImage { get; set; }

        [XmlElement("CapStyle", typeof(string))]
        public string CapStyle { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("OnTop", typeof(string))]
        public string OnTop { get; set; }

        [XmlElement("Reflection", typeof(string))]
        public string Reflection { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }
    }
}