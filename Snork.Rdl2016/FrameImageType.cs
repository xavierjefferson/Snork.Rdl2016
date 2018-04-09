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
    public class FrameImageType
    {
        /// <remarks />
        [XmlElement("ClipImage", typeof(string))]
        public string ClipImage { get; set; }

        [XmlElement("HueColor", typeof(string))]
        public string HueColor { get; set; }

        [XmlElement("MIMEType", typeof(string))]
        public string MIMEType { get; set; }

        [XmlElement("Source", typeof(string))]
        public string Source { get; set; }

        [XmlElement("Transparency", typeof(string))]
        public string Transparency { get; set; }

        [XmlElement("TransparentColor", typeof(string))]
        public string TransparentColor { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }
    }
}