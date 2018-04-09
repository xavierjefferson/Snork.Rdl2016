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
    public class MapLocationType
    {
        /// <remarks />
        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("Unit", typeof(string))]
        public string Unit { get; set; }
    }
}