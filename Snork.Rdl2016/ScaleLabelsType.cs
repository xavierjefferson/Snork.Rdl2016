using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
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
    public class ScaleLabelsType
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

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("IntervalOffset", typeof(string))]
        public string IntervalOffset { get; set; }

        [XmlElement("Placement", typeof(string))]
        public string Placement { get; set; }

        [XmlElement("RotateLabels", typeof(string))]
        public List<string> RotateLabels { get; set; } = new List<string>();

        [XmlElement("ShowEndLabels", typeof(string))]
        public List<string> ShowEndLabels { get; set; } = new List<string>();

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("UseFontPercent", typeof(string))]
        public string UseFontPercent { get; set; }
    }
}