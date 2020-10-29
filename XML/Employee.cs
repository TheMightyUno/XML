using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization; // used to create the XML Serialization
using System.IO; // This is needed for the TextWriter

namespace XMLSample2
{
    public class Employee //NOTE YO CANNOT SERIALIZE PRIVATE FIELDS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; } // using DateTime method. Predefined method method in .NET Framework
    }
}
