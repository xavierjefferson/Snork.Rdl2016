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
    public class FilterType
    {
        /// <remarks />
        [XmlElement("FilterExpression", typeof(string))]
        public string FilterExpression { get; set; }

        [XmlElement("FilterValues", typeof(FilterValuesType))]
        public List<FilterValuesType> FilterValues { get; set; } = new List<FilterValuesType>();

        [XmlElement("Operator", typeof(FilterTypeOperator))]
        public FilterTypeOperator Operator { get; set; }
    }
}