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
    public class CustomLabelType
    {
        /// <remarks />
        [XmlElement("AllowUpsideDown", typeof(string))]
        public string AllowUpsideDown { get; set; }

        [XmlElement("DistanceFromScale", typeof(string))]
        public string DistanceFromScale { get; set; }

        [XmlElement("FontAngle", typeof(string))]
        public string FontAngle { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Placement", typeof(string))]
        public string Placement { get; set; }

        [XmlElement("RotateLabel", typeof(string))]
        public string RotateLabel { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("Text", typeof(string))]
        public string Text { get; set; }

        [XmlElement("TickMarkStyle", typeof(TickMarkStyleType))]
        public TickMarkStyleType TickMarkStyle { get; set; }

        [XmlElement("UseFontPercent", typeof(string))]
        public string UseFontPercent { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}