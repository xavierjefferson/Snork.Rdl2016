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
    public class ChartNoMoveDirectionsType
    {
        /// <remarks />
        [XmlElement("Down", typeof(string))]
        public string Down { get; set; }

        [XmlElement("DownLeft", typeof(string))]
        public string DownLeft { get; set; }

        [XmlElement("DownRight", typeof(string))]
        public string DownRight { get; set; }

        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("Right", typeof(string))]
        public string Right { get; set; }

        [XmlElement("Up", typeof(string))]
        public string Up { get; set; }

        [XmlElement("UpLeft", typeof(string))]
        public string UpLeft { get; set; }

        [XmlElement("UpRight", typeof(string))]
        public string UpRight { get; set; }
    }
}