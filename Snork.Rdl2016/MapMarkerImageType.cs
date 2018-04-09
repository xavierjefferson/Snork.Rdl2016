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
    public class MapMarkerImageType
    {
        /// <remarks />
        [XmlElement("MIMEType", typeof(string))]
        public string MIMEType { get; set; }

        [XmlElement("ResizeMode", typeof(string))]
        public string ResizeMode { get; set; }

        [XmlElement("Source", typeof(string))]
        public string Source { get; set; }

        [XmlElement("TransparentColor", typeof(string))]
        public string TransparentColor { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }
    }
}