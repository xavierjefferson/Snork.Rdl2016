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
    public class ChartThreeDPropertiesType
    {
        /// <remarks />
        [XmlElement("Clustered", typeof(string))]
        public string Clustered { get; set; }

        [XmlElement("DepthRatio", typeof(string))]
        public string DepthRatio { get; set; }

        [XmlElement("Enabled", typeof(string))]
        public string Enabled { get; set; }

        [XmlElement("GapDepth", typeof(string))]
        public string GapDepth { get; set; }

        [XmlElement("Inclination", typeof(string))]
        public string Inclination { get; set; }

        [XmlElement("Perspective", typeof(string))]
        public string Perspective { get; set; }

        [XmlElement("ProjectionMode", typeof(string))]
        public string ProjectionMode { get; set; }

        [XmlElement("Rotation", typeof(string))]
        public string Rotation { get; set; }

        [XmlElement("Shading", typeof(string))]
        public string Shading { get; set; }

        [XmlElement("WallThickness", typeof(string))]
        public List<string> WallThickness { get; set; } = new List<string>();
    }
}