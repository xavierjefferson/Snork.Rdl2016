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
    public class StyleType
    {
        /// <remarks />
        [XmlElement("BackgroundColor", typeof(string))]
        public string BackgroundColor { get; set; }

        [XmlElement("BackgroundGradientEndColor", typeof(string))]
        public string BackgroundGradientEndColor { get; set; }

        [XmlElement("BackgroundGradientType", typeof(string))]
        public string BackgroundGradientType { get; set; }

        [XmlElement("BackgroundHatchType", typeof(string))]
        public string BackgroundHatchType { get; set; }

        [XmlElement("BackgroundImage", typeof(BackgroundImageType))]
        public BackgroundImageType BackgroundImage { get; set; }

        [XmlElement("Border", typeof(BorderType))]
        public BorderType Border { get; set; }

        [XmlElement("BottomBorder", typeof(BorderType))]
        public BorderType BottomBorder { get; set; }

        [XmlElement("Calendar", typeof(string))]
        public string Calendar { get; set; }

        [XmlElement("Color", typeof(string))]
        public string Color { get; set; }

        [XmlElement("Direction", typeof(string))]
        public string Direction { get; set; }

        [XmlElement("FontFamily", typeof(string))]
        public string FontFamily { get; set; }

        [XmlElement("FontSize", typeof(string))]
        public string FontSize { get; set; }

        [XmlElement("FontStyle", typeof(string))]
        public string FontStyle { get; set; }

        [XmlElement("FontWeight", typeof(string))]
        public string FontWeight { get; set; }

        [XmlElement("Format", typeof(string))]
        public string Format { get; set; }

        [XmlElement("Language", typeof(string))]
        public string Language { get; set; }

        [XmlElement("LeftBorder", typeof(BorderType))]
        public BorderType LeftBorder { get; set; }

        [XmlElement("LineHeight", typeof(string))]
        public string LineHeight { get; set; }

        [XmlElement("NumeralLanguage", typeof(string))]
        public string NumeralLanguage { get; set; }

        [XmlElement("NumeralVariant", typeof(string))]
        public string NumeralVariant { get; set; }

        [XmlElement("PaddingBottom", typeof(string))]
        public string PaddingBottom { get; set; }

        [XmlElement("PaddingLeft", typeof(string))]
        public string PaddingLeft { get; set; }

        [XmlElement("PaddingRight", typeof(string))]
        public string PaddingRight { get; set; }

        [XmlElement("PaddingTop", typeof(string))]
        public string PaddingTop { get; set; }

        [XmlElement("RightBorder", typeof(BorderType))]
        public BorderType RightBorder { get; set; }

        [XmlElement("ShadowColor", typeof(string))]
        public string ShadowColor { get; set; }

        [XmlElement("ShadowOffset", typeof(string))]
        public string ShadowOffset { get; set; }

        [XmlElement("TextAlign", typeof(string))]
        public string TextAlign { get; set; }

        [XmlElement("TextDecoration", typeof(string))]
        public string TextDecoration { get; set; }

        [XmlElement("TextEffect", typeof(string))]
        public string TextEffect { get; set; }

        [XmlElement("TopBorder", typeof(BorderType))]
        public BorderType TopBorder { get; set; }

        [XmlElement("UnicodeBiDi", typeof(string))]
        public string UnicodeBiDi { get; set; }

        [XmlElement("VerticalAlign", typeof(string))]
        public string VerticalAlign { get; set; }

        [XmlElement("WritingMode", typeof(string))]
        public string WritingMode { get; set; }
    }
}