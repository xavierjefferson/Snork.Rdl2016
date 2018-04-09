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
    public class MapDistanceScaleType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("BottomMargin", typeof(string))]
        public string BottomMargin { get; set; }

        [XmlElement("DockOutsideViewport", typeof(string))]
        public string DockOutsideViewport { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("LeftMargin", typeof(string))]
        public string LeftMargin { get; set; }

        [XmlElement("MapLocation", typeof(MapLocationType))]
        public MapLocationType MapLocation { get; set; }

        [XmlElement("MapSize", typeof(MapSizeType))]
        public MapSizeType MapSize { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("RightMargin", typeof(string))]
        public string RightMargin { get; set; }

        [XmlElement("ScaleBorderColor", typeof(string))]
        public string ScaleBorderColor { get; set; }

        [XmlElement("ScaleColor", typeof(string))]
        public string ScaleColor { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("TopMargin", typeof(string))]
        public string TopMargin { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }
    }
}