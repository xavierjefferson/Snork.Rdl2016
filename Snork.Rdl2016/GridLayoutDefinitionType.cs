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
    public class GridLayoutDefinitionType
    {
        /// <remarks />
        [XmlArray("CellDefinitions")]
        [XmlArrayItem("CellDefinition", typeof(CellDefinitionType))]
        public List<CellDefinitionType> CellDefinitions { get; set; } = new List<CellDefinitionType>();


        [XmlElement("NumberOfColumns", typeof(int))]
        public int NumberOfColumns { get; set; }

        [XmlElement("NumberOfRows", typeof(int))]
        public int NumberOfRows { get; set; }
    }
}
