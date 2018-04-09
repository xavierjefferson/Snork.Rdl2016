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
    public class MapBucketType
    {
        /// <remarks />
        [XmlElement("EndValue", typeof(string))]
        public string EndValue { get; set; }

        [XmlElement("StartValue", typeof(string))]
        public string StartValue { get; set; }
    }
}