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
    public class ChartSeriesType
    {
        /// <remarks />
        [XmlElement("CategoryAxisName", typeof(string))]
        public string CategoryAxisName { get; set; }

        [XmlElement("ChartAreaName", typeof(string))]
        public string ChartAreaName { get; set; }

        [XmlElement("ChartDataLabel", typeof(ChartDataLabelType))]
        public ChartDataLabelType ChartDataLabel { get; set; }

        [XmlArray("ChartDataPoints")]
        [XmlArrayItem("ChartDataPoint", typeof(ChartDataPointType))]
        public List<ChartDataPointType> ChartDataPoints { get; set; } = new List<ChartDataPointType>();


        [XmlElement("ChartEmptyPoints", typeof(ChartEmptyPointsType))]
        public List<ChartEmptyPointsType> ChartEmptyPoints { get; set; } = new List<ChartEmptyPointsType>();

        [XmlElement("ChartItemInLegend", typeof(ChartItemInLegendType))]
        public ChartItemInLegendType ChartItemInLegend { get; set; }

        [XmlElement("ChartMarker", typeof(ChartMarkerType))]
        public ChartMarkerType ChartMarker { get; set; }

        [XmlElement("ChartSmartLabel", typeof(ChartSmartLabelType))]
        public ChartSmartLabelType ChartSmartLabel { get; set; }

        [XmlElement("CustomProperties", typeof(CustomPropertiesType))]
        public List<CustomPropertiesType> CustomProperties { get; set; } = new List<CustomPropertiesType>();

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("LegendName", typeof(string))]
        public string LegendName { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("Subtype", typeof(string))]
        public string Subtype { get; set; }

        [XmlElement("Type", typeof(string))]
        public string Type { get; set; }

        [XmlElement("ValueAxisName", typeof(string))]
        public string ValueAxisName { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}