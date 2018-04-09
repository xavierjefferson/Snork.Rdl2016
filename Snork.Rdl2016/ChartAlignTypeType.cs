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
    public class ChartAlignTypeType
    {
        /// <remarks />
        [XmlElement("AxesView", typeof(string))]
        public string AxesView { get; set; }

        [XmlElement("Cursor", typeof(string))]
        public string Cursor { get; set; }

        [XmlElement("InnerPlotPosition", typeof(string))]
        public string InnerPlotPosition { get; set; }

        [XmlElement("Position", typeof(string))]
        public string Position { get; set; }
    }
}