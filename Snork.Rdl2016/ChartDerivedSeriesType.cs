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
    public class ChartDerivedSeriesType
    {
        /// <remarks />
        [XmlArray("ChartFormulaParameters")]
        [XmlArrayItem("ChartFormulaParameter", typeof(ChartFormulaParameterType))]
        public List<ChartFormulaParameterType> ChartFormulaParameters { get; set; } = new List<ChartFormulaParameterType>();

           

        [XmlElement("ChartSeries", typeof(ChartSeriesType))]
        public List<ChartSeriesType> ChartSeries { get; set; } = new List<ChartSeriesType>();

        [XmlElement("DerivedSeriesFormula", typeof(ChartDerivedSeriesTypeDerivedSeriesFormula))]
        public ChartDerivedSeriesTypeDerivedSeriesFormula DerivedSeriesFormula { get; set; }

        [XmlElement("SourceChartSeriesName", typeof(string))]
        public string SourceChartSeriesName { get; set; }
    }
}
