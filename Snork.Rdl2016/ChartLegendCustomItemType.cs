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
    public class ChartLegendCustomItemType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlArray("ChartLegendCustomItemCells")]
        [XmlArrayItem("ChartLegendCustomItemCell", typeof(ChartLegendCustomItemCellType))]
        public List<ChartLegendCustomItemCellType> ChartLegendCustomItemCells { get; set; } = new List<ChartLegendCustomItemCellType>();

          

        [XmlElement("ChartMarker", typeof(ChartMarkerType))]
        public ChartMarkerType ChartMarker { get; set; }

        [XmlElement("Separator", typeof(string))]
        public string Separator { get; set; }

        [XmlElement("SeparatorColor", typeof(string))]
        public string SeparatorColor { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}
