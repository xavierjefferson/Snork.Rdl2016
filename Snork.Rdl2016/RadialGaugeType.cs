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
    public class RadialGaugeType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("AspectRatio", typeof(string))]
        public string AspectRatio { get; set; }

        [XmlElement("BackFrame", typeof(BackFrameType))]
        public BackFrameType BackFrame { get; set; }

        [XmlElement("ClipContent", typeof(string))]
        public string ClipContent { get; set; }

        [XmlArray("GaugeScales")]
        [XmlArrayItem("RadialScale", typeof(RadialScaleType))]
        public List<RadialScaleType> GaugeScales { get; set; } = new List<RadialScaleType>();

        [XmlElement("Height", typeof(string))]
        public string Height { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("ParentItem", typeof(string))]
        public string ParentItem { get; set; }

        [XmlElement("PivotX", typeof(string))]
        public string PivotX { get; set; }

        [XmlElement("PivotY", typeof(string))]
        public string PivotY { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("TopImage", typeof(TopImageType))]
        public TopImageType TopImage { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}