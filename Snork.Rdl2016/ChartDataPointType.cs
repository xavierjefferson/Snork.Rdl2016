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
    public class ChartDataPointType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("AxisLabel", typeof(string))]
        public string AxisLabel { get; set; }

        [XmlElement("ChartDataLabel", typeof(ChartDataLabelType))]
        public ChartDataLabelType ChartDataLabel { get; set; }

        [XmlElement("ChartDataPointValues", typeof(ChartDataPointValuesType))]
        public List<ChartDataPointValuesType> ChartDataPointValues { get; set; } = new List<ChartDataPointValuesType>();

        [XmlElement("ChartItemInLegend", typeof(ChartItemInLegendType))]
        public ChartItemInLegendType ChartItemInLegend { get; set; }

        [XmlElement("ChartMarker", typeof(ChartMarkerType))]
        public ChartMarkerType ChartMarker { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(ChartDataPointTypeDataElementOutput))]
        public ChartDataPointTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }
    }
}