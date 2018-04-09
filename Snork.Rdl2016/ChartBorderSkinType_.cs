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
    public class ChartBorderSkinType_
    {
        /// <remarks />
        [XmlElement("ChartBorderSkinType", typeof(string))]
        public string ChartBorderSkinType { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }
    }
}