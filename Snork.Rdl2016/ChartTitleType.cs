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
    public class ChartTitleType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Caption", typeof(StringLocIDType))]
        public StringLocIDType Caption { get; set; }

        [XmlElement("ChartElementPosition", typeof(ChartElementPositionType))]
        public ChartElementPositionType ChartElementPosition { get; set; }

        [XmlElement("DockOffset", typeof(string))]
        public string DockOffset { get; set; }

        [XmlElement("DockOutsideChartArea", typeof(string))]
        public string DockOutsideChartArea { get; set; }

        [XmlElement("DockToChartArea", typeof(string))]
        public string DockToChartArea { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("TextOrientation", typeof(string))]
        public string TextOrientation { get; set; }

        [XmlElement("ToolTip", typeof(StringLocIDType))]
        public StringLocIDType ToolTip { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}