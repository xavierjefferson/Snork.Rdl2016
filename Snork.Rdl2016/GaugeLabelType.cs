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
    public class GaugeLabelType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Angle", typeof(string))]
        public string Angle { get; set; }

        [XmlElement("Height", typeof(string))]
        public string Height { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("ParentItem", typeof(string))]
        public string ParentItem { get; set; }

        [XmlElement("ResizeMode", typeof(string))]
        public string ResizeMode { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("Text", typeof(string))]
        public string Text { get; set; }

        [XmlElement("TextShadowOffset", typeof(string))]
        public string TextShadowOffset { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("UseFontPercent", typeof(string))]
        public string UseFontPercent { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}