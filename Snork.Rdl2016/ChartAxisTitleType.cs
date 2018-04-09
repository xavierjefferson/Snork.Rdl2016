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
    public class ChartAxisTitleType
    {
        /// <remarks />
        [XmlElement("Caption", typeof(StringLocIDType))]
        public StringLocIDType Caption { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextOrientation", typeof(string))]
        public string TextOrientation { get; set; }
    }
}