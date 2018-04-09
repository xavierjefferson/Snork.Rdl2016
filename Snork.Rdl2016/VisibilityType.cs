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
    public class VisibilityType
    {
        /// <remarks />
        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("ToggleItem", typeof(string))]
        public string ToggleItem { get; set; }
    }
}