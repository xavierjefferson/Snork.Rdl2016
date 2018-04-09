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
    public class ScalePinType
    {
        /// <remarks />
        [XmlElement("DistanceFromScale", typeof(string))]
        public string DistanceFromScale { get; set; }

        [XmlElement("Enable", typeof(string))]
        public string Enable { get; set; }

        [XmlElement("EnableGradient", typeof(string))]
        public string EnableGradient { get; set; }

        [XmlElement("GradientDensity", typeof(string))]
        public string GradientDensity { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Length", typeof(string))]
        public string Length { get; set; }

        [XmlElement("Location", typeof(string))]
        public string Location { get; set; }

        [XmlElement("PinLabel", typeof(PinLabelType))]
        public PinLabelType PinLabel { get; set; }

        [XmlElement("Placement", typeof(string))]
        public string Placement { get; set; }

        [XmlElement("Shape", typeof(string))]
        public string Shape { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TickMarkImage", typeof(TopImageType))]
        public TopImageType TickMarkImage { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }
    }
}