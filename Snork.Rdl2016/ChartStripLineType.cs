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
    public class ChartStripLineType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Interval", typeof(string))]
        public string Interval { get; set; }

        [XmlElement("IntervalOffset", typeof(string))]
        public string IntervalOffset { get; set; }

        [XmlElement("IntervalOffsetType", typeof(string))]
        public string IntervalOffsetType { get; set; }

        [XmlElement("IntervalType", typeof(string))]
        public string IntervalType { get; set; }

        [XmlElement("StripWidth", typeof(string))]
        public string StripWidth { get; set; }

        [XmlElement("StripWidthType", typeof(string))]
        public string StripWidthType { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextOrientation", typeof(string))]
        public string TextOrientation { get; set; }

        [XmlElement("Title", typeof(string))]
        public string Title { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }
    }
}