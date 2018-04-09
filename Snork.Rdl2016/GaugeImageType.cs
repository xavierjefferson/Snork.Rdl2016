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
    public class GaugeImageType
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

        [XmlElement("MIMEType", typeof(string))]
        public string MIMEType { get; set; }

        [XmlElement("ParentItem", typeof(string))]
        public string ParentItem { get; set; }

        [XmlElement("ResizeMode", typeof(string))]
        public string ResizeMode { get; set; }

        [XmlElement("Source", typeof(string))]
        public string Source { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("Transparency", typeof(string))]
        public string Transparency { get; set; }

        [XmlElement("TransparentColor", typeof(string))]
        public string TransparentColor { get; set; }

        [XmlElement("Value", typeof(string))]
        public string Value { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}