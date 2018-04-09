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
    public class ThermometerType
    {
        /// <remarks />
        [XmlElement("BulbOffset", typeof(string))]
        public string BulbOffset { get; set; }

        [XmlElement("BulbSize", typeof(string))]
        public string BulbSize { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ThermometerStyle", typeof(string))]
        public string ThermometerStyle { get; set; }
    }
}