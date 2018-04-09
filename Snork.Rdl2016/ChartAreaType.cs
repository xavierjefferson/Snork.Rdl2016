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
    public class ChartAreaType
    {
        /// <remarks />
        [XmlElement("AlignOrientation", typeof(string))]
        public string AlignOrientation { get; set; }

        [XmlElement("AlignWithChartArea", typeof(string))]
        public string AlignWithChartArea { get; set; }

        [XmlElement("ChartAlignType", typeof(ChartAlignTypeType))]
        public ChartAlignTypeType ChartAlignType { get; set; }

        [XmlElement("ChartCategoryAxes", typeof(ChartCategoryAxesType))]
        public List<ChartCategoryAxesType> ChartCategoryAxes { get; set; } = new List<ChartCategoryAxesType>();

        [XmlElement("ChartElementPosition", typeof(ChartElementPositionType))]
        public ChartElementPositionType ChartElementPosition { get; set; }

        [XmlElement("ChartInnerPlotPosition", typeof(ChartElementPositionType))]
        public ChartElementPositionType ChartInnerPlotPosition { get; set; }

        [XmlElement("ChartThreeDProperties", typeof(ChartThreeDPropertiesType))]
        public List<ChartThreeDPropertiesType> ChartThreeDProperties { get; set; } =
            new List<ChartThreeDPropertiesType>();

        [XmlElement("ChartValueAxes", typeof(ChartValueAxesType))]
        public List<ChartValueAxesType> ChartValueAxes { get; set; } = new List<ChartValueAxesType>();

        [XmlElement("EquallySizedAxesFont", typeof(string))]
        public string EquallySizedAxesFont { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}