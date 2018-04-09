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
    public class ActionInfoType
    {
        /// <remarks />
        [XmlArray("Actions")]
        [XmlArrayItem("Action", typeof(ActionType))]
        public List<ActionType> Actions { get; set; } = new List<ActionType>();

        Snork.Rdl2016.Report ReadAFile(string rdlFilename)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Report));
            Snork.Rdl2016.Report report;
            using (var stream = System.IO.File.OpenRead(rdlFilename))
            {
                report = (Snork.Rdl2016.Report)serializer.Deserialize(stream);
            }
            return report;
        }
    }
}