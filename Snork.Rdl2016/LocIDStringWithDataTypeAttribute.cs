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
    public class LocIDStringWithDataTypeAttribute : StringWithDataTypeAttribute
    {
        public LocIDStringWithDataTypeAttribute()
        {
            EvaluationMode = EvaluationModeType.Auto;
        }

        /// <remarks />
        [XmlAttribute]
        [DefaultValue(EvaluationModeType.Auto)]
        public EvaluationModeType EvaluationMode { get; set; }
    }
}