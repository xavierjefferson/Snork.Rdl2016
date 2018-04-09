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
    public class MapGridLinesType
    {
        /// <remarks />
        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("LabelPosition", typeof(string))]
        public string LabelPosition { get; set; }

        [XmlElement("ShowLabels", typeof(string))]
        public List<string> ShowLabels { get; set; } = new List<string>();

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}