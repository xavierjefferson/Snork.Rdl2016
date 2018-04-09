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
    public class MapSizeType
    {
        /// <remarks />
        [XmlElement("Height", typeof(string))]
        public string Height { get; set; }

        [XmlElement("Unit", typeof(string))]
        public string Unit { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }
    }
}