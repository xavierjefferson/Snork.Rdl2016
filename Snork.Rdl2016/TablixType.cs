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
    public class TablixType
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

        [XmlElement("DataElementOutput", typeof(TablixTypeDataElementOutput))]
        public TablixTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlElement("FixedColumnHeaders", typeof(bool))]
        public List<bool> FixedColumnHeaders { get; set; } = new List<bool>();

        [XmlElement("FixedRowHeaders", typeof(bool))]
        public List<bool> FixedRowHeaders { get; set; } = new List<bool>();

        [XmlElement("GroupsBeforeRowHeaders", typeof(uint))]
        public List<uint> GroupsBeforeRowHeaders { get; set; } = new List<uint>();

        [XmlElement("KeepTogether", typeof(bool))]
        public bool KeepTogether { get; set; }

        [XmlElement("LayoutDirection", typeof(TablixTypeLayoutDirection))]
        public TablixTypeLayoutDirection LayoutDirection { get; set; }

        [XmlElement("NoRowsMessage", typeof(string))]
        public string NoRowsMessage { get; set; }

        [XmlElement("OmitBorderOnPageBreak", typeof(bool))]
        public bool OmitBorderOnPageBreak { get; set; }

        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlElement("RepeatColumnHeaders", typeof(bool))]
        public List<bool> RepeatColumnHeaders { get; set; } = new List<bool>();

        [XmlElement("RepeatRowHeaders", typeof(bool))]
        public List<bool> RepeatRowHeaders { get; set; } = new List<bool>();

        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();


        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TablixBody", typeof(TablixBodyType))]
        public TablixBodyType TablixBody { get; set; }

        [XmlElement("TablixColumnHierarchy", typeof(TablixHierarchyType))]
        public TablixHierarchyType TablixColumnHierarchy { get; set; }

        [XmlElement("TablixCorner", typeof(TablixCornerType))]
        public TablixCornerType TablixCorner { get; set; }

        [XmlElement("TablixRowHierarchy", typeof(TablixHierarchyType))]
        public TablixHierarchyType TablixRowHierarchy { get; set; }

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