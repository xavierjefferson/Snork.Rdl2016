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
    public class StateIndicatorType
    {
        /// <remarks />
        [XmlElement("ActionInfo", typeof(ActionInfoType))]
        public ActionInfoType ActionInfo { get; set; }

        [XmlElement("Angle", typeof(string))]
        public string Angle { get; set; }

        [XmlElement("GaugeInputValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType GaugeInputValue { get; set; }

        [XmlElement("Height", typeof(string))]
        public string Height { get; set; }

        [XmlElement("Hidden", typeof(string))]
        public string Hidden { get; set; }

        [XmlElement("IndicatorImage", typeof(IndicatorImageType))]
        public IndicatorImageType IndicatorImage { get; set; }

        [XmlArray("IndicatorStates")]
        [XmlArrayItem("IndicatorState", typeof(IndicatorStateType))]
        public List<IndicatorStateType> IndicatorStates { get; set; } = new List<IndicatorStateType>();


        [XmlElement("IndicatorStyle", typeof(string))]
        public string IndicatorStyle { get; set; }

        [XmlElement("Left", typeof(string))]
        public string Left { get; set; }

        [XmlElement("MaximumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MaximumValue { get; set; }

        [XmlElement("MinimumValue", typeof(GaugeInputValueType))]
        public GaugeInputValueType MinimumValue { get; set; }

        [XmlElement("ParentItem", typeof(string))]
        public string ParentItem { get; set; }

        [XmlElement("ResizeMode", typeof(string))]
        public string ResizeMode { get; set; }

        [XmlElement("ScaleFactor", typeof(string))]
        public string ScaleFactor { get; set; }

        [XmlElement("StateDataElementName", typeof(string))]
        public string StateDataElementName { get; set; }

        [XmlElement("StateDataElementOutput", typeof(StateIndicatorTypeStateDataElementOutput))]
        public StateIndicatorTypeStateDataElementOutput StateDataElementOutput { get; set; }

        [XmlElement("Style", typeof(StyleType))]
        public StyleType Style { get; set; }

        [XmlElement("ToolTip", typeof(string))]
        public string ToolTip { get; set; }

        [XmlElement("Top", typeof(string))]
        public string Top { get; set; }

        [XmlElement("TransformationScope", typeof(string))]
        public string TransformationScope { get; set; }

        [XmlElement("TransformationType", typeof(string))]
        public string TransformationType { get; set; }

        [XmlElement("Width", typeof(string))]
        public string Width { get; set; }

        [XmlElement("ZIndex", typeof(string))]
        public string ZIndex { get; set; }


        /// <remarks />
        [XmlAttribute(DataType = "normalizedString")]
        public string Name { get; set; }
    }
}