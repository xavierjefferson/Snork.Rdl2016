using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Snork.Rdl2016;

namespace TestSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Xml.Serialization.XmlSerializer xs = new XmlSerializer(typeof(Report));
            using (var f = System.IO.File.OpenRead("Product Line Sales 2016.rdl"))
            {
                var c = xs.Deserialize(f);
            }
        }
    }
}
