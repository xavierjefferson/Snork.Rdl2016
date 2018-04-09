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
    public class TablixCellType
    {
        /// <remarks />
        [XmlElement("CellContents", typeof(CellContentsType))]
        public List<CellContentsType> CellContents { get; set; } = new List<CellContentsType>();

        [XmlElement("DataElementName", typeof(string))]
        public string DataElementName { get; set; }

        [XmlElement("DataElementOutput", typeof(TablixCellTypeDataElementOutput))]
        public TablixCellTypeDataElementOutput DataElementOutput { get; set; }
    }
}