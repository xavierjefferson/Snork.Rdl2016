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
    public class MapLineRulesType
    {
        /// <remarks />
        [XmlElement("MapColorPaletteRule", typeof(MapColorPaletteRuleType))]
        public MapColorPaletteRuleType MapColorPaletteRule { get; set; }

        [XmlElement("MapColorRangeRule", typeof(MapColorRangeRuleType))]
        public MapColorRangeRuleType MapColorRangeRule { get; set; }

        [XmlElement("MapCustomColorRule", typeof(MapCustomColorRuleType))]
        public MapCustomColorRuleType MapCustomColorRule { get; set; }

        [XmlElement("MapSizeRule", typeof(MapSizeRuleType))]
        public MapSizeRuleType MapSizeRule { get; set; }
    }
}