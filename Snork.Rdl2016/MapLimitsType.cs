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
    public class MapLimitsType
    {
        /// <remarks />
        [XmlElement("MaximumX", typeof(string))]
        public string MaximumX { get; set; }

        [XmlElement("MaximumY", typeof(string))]
        public string MaximumY { get; set; }

        [XmlElement("MinimumX", typeof(string))]
        public string MinimumX { get; set; }

        [XmlElement("MinimumY", typeof(string))]
        public string MinimumY { get; set; }
    }
}