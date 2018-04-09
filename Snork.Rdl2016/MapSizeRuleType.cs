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
    public class MapSizeRuleType
    {
        /// <remarks />
        [XmlElement("BucketCount", typeof(string))]
        public string BucketCount { get; set; }

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(MapSizeRuleTypeDataElementOutput))]
        public MapSizeRuleTypeDataElementOutput DataElementOutput { get; set; }

        [XmlElement("DataValue", typeof(string))]
        public string DataValue { get; set; }

        [XmlElement("DistributionType", typeof(string))]
        public string DistributionType { get; set; }

        [XmlElement("EndSize", typeof(string))]
        public string EndSize { get; set; }

        [XmlElement("EndValue", typeof(string))]
        public string EndValue { get; set; }

        [XmlElement("LegendName", typeof(string))]
        public string LegendName { get; set; }

        [XmlElement("LegendText", typeof(string))]
        public string LegendText { get; set; }

        [XmlArray("MapBuckets")]
        [XmlArrayItem("MapBucket", typeof(MapBucketType))]
        public List<MapBucketType> MapBuckets { get; set; } = new List<MapBucketType>();


        [XmlElement("StartSize", typeof(string))]
        public string StartSize { get; set; }

        [XmlElement("StartValue", typeof(string))]
        public string StartValue { get; set; }
    }
}