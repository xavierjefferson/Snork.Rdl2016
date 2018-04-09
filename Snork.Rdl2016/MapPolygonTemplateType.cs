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
    public class MapPolygonTemplateType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("CenterPointOffsetX", typeof(string))]
        public string CenterPointOffsetX { get; set; }

        [XmlElement("CenterPointOffsetY", typeof(string))]
        public string CenterPointOffsetY { get; set; }

        [XmlElement("DataElementLabel", typeof(string))]
        public string DataElementLabel { get; set; }

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(MapPolygonTemplateTypeDataElementOutput))]
        public MapPolygonTemplateTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Label", typeof(string))]
        public string Label { get; set; }

        [XmlElement("LabelPlacement", typeof(string))]
        public string LabelPlacement { get; set; }

        [XmlElement("OffsetX", typeof(string))]
        public string OffsetX { get; set; }

        [XmlElement("OffsetY", typeof(string))]
        public string OffsetY { get; set; }

        [XmlElement("ScaleFactor", typeof(string))]
        public string ScaleFactor { get; set; }

        [XmlElement("ShowLabel", typeof(string))]
        public string ShowLabel { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }
    }
}