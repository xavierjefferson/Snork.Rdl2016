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
    public class RectangleType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Bookmark", typeof(string))]
        public string Bookmark { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(RectangleTypeDataElementOutput))]
        public RectangleTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlElement("KeepTogether", typeof(bool))]
        public bool KeepTogether { get; set; }

        [XmlElement("LinkToChild", typeof(string))]
        public string LinkToChild { get; set; }

        [XmlElement("OmitBorderOnPageBreak", typeof(bool))]
        public bool OmitBorderOnPageBreak { get; set; }

        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlElement("ReportItems", typeof(ReportItemsType))]
        public List<ReportItemsType> ReportItems { get; set; } = new List<ReportItemsType>();

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("Visibility", typeof(VisibilityType))]
        public VisibilityType Visibility { get; set; }

        [XmlElement("ZIndex", typeof(uint))]
        public uint ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}