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
    public class ChartDataLabelType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Label", typeof(StringLocIDType))]
        public StringLocIDType Label { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("Rotation", typeof(string))]
        public string Rotation { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("UseValueAsLabel", typeof(string))]
        public string UseValueAsLabel { get; set; }

        [XmlElement("Visible", typeof(string))]
        public string Visible { get; set; }
    }
}