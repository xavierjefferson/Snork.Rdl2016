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
    public class ParagraphType
    {
        /// <remarks />
        [XmlElement("HangingIndent", typeof(string))]
        public string HangingIndent { get; set; }

        [XmlElement("LeftIndent", typeof(string))]
        public string LeftIndent { get; set; }

        [XmlElement("ListLevel", typeof(uint))]
        public uint ListLevel { get; set; }

        [XmlElement("ListStyle", typeof(ParagraphTypeListStyle))]
        public ParagraphTypeListStyle ListStyle { get; set; }

        [XmlElement("RightIndent", typeof(string))]
        public string RightIndent { get; set; }

        [XmlElement("SpaceAfter", typeof(string))]
        public string SpaceAfter { get; set; }

        [XmlElement("SpaceBefore", typeof(string))]
        public string SpaceBefore { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlArray("TextRuns")]
        [XmlArrayItem("TextRun", typeof(TextRunType))]
        public List<TextRunType> TextRuns { get; set; } = new List<TextRunType>();

    }
}
