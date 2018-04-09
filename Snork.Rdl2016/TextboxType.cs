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
    public class TextboxType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Bookmark", typeof(string))]
        public string Bookmark { get; set; }

        [XmlElement("CanGrow", typeof(bool))]
        public bool CanGrow { get; set; }

        [XmlElement("CanShrink", typeof(bool))]
        public bool CanShrink { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(TextboxTypeDataElementOutput))]
        public TextboxTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DataElementStyle", typeof(TextboxTypeDataElementStyle))]
        public TextboxTypeDataElementStyle DataElementStyle { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlElement("HideDuplicates", typeof(string))]
        public List<string> HideDuplicates { get; set; } = new List<string>();

        [XmlElement("KeepTogether", typeof(bool))]
        public bool KeepTogether { get; set; }

        [XmlArray("Paragraphs")]
        [XmlArrayItem("Paragraph", typeof(ParagraphType))]
        public List<ParagraphType> Paragraphs { get; set; } = new List<ParagraphType>();


        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToggleImage", typeof(ToggleImageType))]
        public ToggleImageType ToggleImage { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("UserSort", typeof(UserSortType))]
        public UserSortType UserSort { get; set; }

        [XmlElement("Visibility", typeof(VisibilityType))]
        public VisibilityType Visibility { get; set; }

        [XmlElement("ZIndex", typeof(uint))]
        public uint ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
