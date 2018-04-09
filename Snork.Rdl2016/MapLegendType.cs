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
    public class MapLegendType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("AutoFitTextDisabled", typeof(string))]
        public string AutoFitTextDisabled { get; set; }

        [XmlElement("BottomMargin", typeof(string))]
        public string BottomMargin { get; set; }

        [XmlElement("DockOutsideViewport", typeof(string))]
        public string DockOutsideViewport { get; set; }

        [XmlElement("EquallySpacedItems", typeof(string))]
        public List<string> EquallySpacedItems { get; set; } = new List<string>();

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("InterlacedRows", typeof(string))]
        public List<string> InterlacedRows { get; set; } = new List<string>();

        [XmlElement("InterlacedRowsColor", typeof(string))]
        public string InterlacedRowsColor { get; set; }

        [XmlElement("Layout", typeof(string))]
        public string Layout { get; set; }

        [XmlElement("LeftMargin", typeof(string))]
        public string LeftMargin { get; set; }

        [XmlElement("MapLegendTitle", typeof(MapLegendTitleType))]
        public MapLegendTitleType MapLegendTitle { get; set; }

        [XmlElement("MapLocation", typeof(MapLocationType))]
        public MapLocationType MapLocation { get; set; }

        [XmlElement("MapSize", typeof(MapSizeType))]
        public MapSizeType MapSize { get; set; }

        [XmlElement("MinFontSize", typeof(string))]
        public string MinFontSize { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("RightMargin", typeof(string))]
        public string RightMargin { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextWrapThreshold", typeof(string))]
        public string TextWrapThreshold { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("TopMargin", typeof(string))]
        public string TopMargin { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}