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
    public class ChartSmartLabelType
    {
        /// <remarks />
        [XmlElement("AllowOutSidePlotArea", typeof(string))]
        public string AllowOutSidePlotArea { get; set; }

        [XmlElement("CalloutBackColor", typeof(string))]
        public string CalloutBackColor { get; set; }

        [XmlElement("CalloutLineAnchor", typeof(string))]
        public string CalloutLineAnchor { get; set; }

        [XmlElement("CalloutLineColor", typeof(string))]
        public string CalloutLineColor { get; set; }

        [XmlElement("CalloutLineStyle", typeof(string))]
        public string CalloutLineStyle { get; set; }

        [XmlElement("CalloutLineWidth", typeof(string))]
        public string CalloutLineWidth { get; set; }

        [XmlElement("CalloutStyle", typeof(string))]
        public string CalloutStyle { get; set; }

        [XmlElement("ChartNoMoveDirections", typeof(ChartNoMoveDirectionsType))]
        public List<ChartNoMoveDirectionsType> ChartNoMoveDirections { get; set; } =
            new List<ChartNoMoveDirectionsType>();

        [XmlElement("Disabled", typeof(string))]
        public string Disabled { get; set; }

        [XmlElement("MarkerOverlapping", typeof(string))]
        public string MarkerOverlapping { get; set; }

        [XmlElement("MaxMovingDistance", typeof(string))]
        public string MaxMovingDistance { get; set; }

        [XmlElement("MinMovingDistance", typeof(string))]
        public string MinMovingDistance { get; set; }

        [XmlElement("ShowOverlapped", typeof(string))]
        public string ShowOverlapped { get; set; }
    }
}