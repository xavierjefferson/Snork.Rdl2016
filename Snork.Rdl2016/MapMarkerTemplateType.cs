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
    public class MapMarkerTemplateType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("DataElementLabel", typeof(string))]
        public string DataElementLabel { get; set; }

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(MapMarkerTemplateTypeDataElementOutput))]
        public MapMarkerTemplateTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Label", typeof(string))]
        public string Label { get; set; }

        [XmlElement("LabelPlacement", typeof(string))]
        public string LabelPlacement { get; set; }

        [XmlElement("MapMarker", typeof(MapMarkerType))]
        public MapMarkerType MapMarker { get; set; }

        [XmlElement("OffsetX", typeof(string))]
        public string OffsetX { get; set; }

        [XmlElement("OffsetY", typeof(string))]
        public string OffsetY { get; set; }

        [XmlElement("Size", typeof(string))]
        public string Size { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }
    }
}