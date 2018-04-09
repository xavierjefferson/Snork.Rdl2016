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
    public class ActionType
    {
        /// <remarks />
        [XmlElement("BookmarkLink", typeof(string))]
        public string BookmarkLink { get; set; }

        [XmlElement("Drillthrough", typeof(DrillthroughType))]
        public DrillthroughType Drillthrough { get; set; }

        [XmlElement("Hyperlink", typeof(string))]
        public string Hyperlink { get; set; }
    }
}