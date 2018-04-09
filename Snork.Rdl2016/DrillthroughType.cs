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
    public class DrillthroughType
    {
        /// <remarks />
        [XmlArray("Parameters")]
        [XmlArrayItem("Parameter", typeof(ParameterType))]
        public List<ParameterType> Parameters { get; set; } = new List<ParameterType>();


        [XmlElement("ReportName", typeof(string))]
        public string ReportName { get; set; }
    }
}
