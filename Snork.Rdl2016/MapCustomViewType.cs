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
    public class MapCustomViewType
    {
        /// <remarks />
        [XmlElement("CenterX", typeof(string))]
        public string CenterX { get; set; }

        [XmlElement("CenterY", typeof(string))]
        public string CenterY { get; set; }

        [XmlElement("Zoom", typeof(string))]
        public string Zoom { get; set; }
    }
}