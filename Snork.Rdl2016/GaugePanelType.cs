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
    public class GaugePanelType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("AntiAliasing", typeof(string))]
        public string AntiAliasing { get; set; }

        [XmlElement("AutoLayout", typeof(string))]
        public string AutoLayout { get; set; }

        [XmlElement("BackFrame", typeof(BackFrameType))]
        public BackFrameType BackFrame { get; set; }

        [XmlElement("Bookmark", typeof(string))]
        public string Bookmark { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(GaugePanelTypeDataElementOutput))]
        public GaugePanelTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DataSetName", typeof(string))]
        public string DataSetName { get; set; }

        [XmlElement("DocumentMapLabel", typeof(StringLocIDType))]
        public StringLocIDType DocumentMapLabel { get; set; }

        [XmlArray("Filters")]
        [XmlArrayItem("Filter", typeof(FilterType))]
        public List<FilterType> Filters { get; set; } = new List<FilterType>();


        [XmlArray("GaugeImages")]
        [XmlArrayItem("GaugeImage", typeof(GaugeImageType))]
        public List<GaugeImageType> GaugeImages { get; set; } = new List<GaugeImageType>();


        [XmlArray("GaugeLabels")]
        [XmlArrayItem("GaugeLabel", typeof(GaugeLabelType))]
        public List<GaugeLabelType> GaugeLabels { get; set; } = new List<GaugeLabelType>();


        [XmlElement("GaugeMember", typeof(GaugeMemberType))]
        public GaugeMemberType GaugeMember { get; set; }

        [XmlArray("LinearGauges")]
        [XmlArrayItem("LinearGauge", typeof(LinearGaugeType))]
        public List<LinearGaugeType> LinearGauges { get; set; } = new List<LinearGaugeType>();


        [XmlElement("NoRowsMessage", typeof(string))]
        public string NoRowsMessage { get; set; }

        [XmlArray("NumericIndicators")]
        [XmlArrayItem("NumericIndicator", typeof(NumericIndicatorType))]
        public List<NumericIndicatorType> NumericIndicators { get; set; } = new List<NumericIndicatorType>();


        [XmlElement("PageBreak", typeof(PageBreakType))]
        public PageBreakType PageBreak { get; set; }

        [XmlElement("PageName", typeof(string))]
        public string PageName { get; set; }

        [XmlArray("RadialGauges")]
        [XmlArrayItem("RadialGauge", typeof(RadialGaugeType))]
        public List<RadialGaugeType> RadialGauges { get; set; } = new List<RadialGaugeType>();


        [XmlElement("RepeatWith", typeof(string))]
        public string RepeatWith { get; set; }

        [XmlElement("ShadowIntensity", typeof(string))]
        public string ShadowIntensity { get; set; }

        [XmlArray("SortExpressions")]
        [XmlArrayItem("SortExpression", typeof(SortExpressionType))]
        public List<SortExpressionType> SortExpressions { get; set; } = new List<SortExpressionType>();


        [XmlArray("StateIndicators")]
        [XmlArrayItem("StateIndicator", typeof(StateIndicatorType))]
        public List<StateIndicatorType> StateIndicators { get; set; } = new List<StateIndicatorType>();


        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextAntiAliasingQuality", typeof(string))]
        public string TextAntiAliasingQuality { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }

        [XmlElement("TopImage", typeof(TopImageType))]
        public TopImageType TopImage { get; set; }

        [XmlElement("Visibility", typeof(VisibilityType))]
        public VisibilityType Visibility { get; set; }

        [XmlElement("ZIndex", typeof(uint))]
        public uint ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}