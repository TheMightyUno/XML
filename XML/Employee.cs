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
    //[Serializable]
    [XmlRoot("New Employees", Namespace = "www.nerdinc.ninja")]
    public class Employee //NOTE YO CANNOT SERIALIZE PRIVATE FIELDS
    {
        [XmlAttribute("Employee ID")]
        public int ID { get; set; }
        [XmlElement("Full Name")]
        public string Name { get; set; }
        [XmlElement("Social Security Number")]
        public double SSNumber { get; set; }
        [XmlElement("Today's Date")]
        public DateTime EntryDate { get; set; } // using DateTime method. Predefined method method in .NET Framework
        public string JobRole { get; set; }
    }
}
