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
    public class BackFrameType
    {
        /// <remarks />
        [XmlElement("FrameBackground", typeof(FrameBackgroundType))]
        public FrameBackgroundType FrameBackground { get; set; }

        [XmlElement("FrameImage", typeof(FrameImageType))]
        public FrameImageType FrameImage { get; set; }

        [XmlElement("FrameShape", typeof(string))]
        public string FrameShape { get; set; }

        [XmlElement("FrameStyle", typeof(string))]
        public string FrameStyle { get; set; }

        [XmlElement("FrameWidth", typeof(string))]
        public string FrameWidth { get; set; }

        [XmlElement("GlassEffect", typeof(string))]
        public string GlassEffect { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}