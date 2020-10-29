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
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //emp.ID = 123;
            //emp.Name = "Chris";
            //emp.SSNumber = 123456789;
            //emp.EntryDate = DateTime.Now;
            //emp.JobRole = "Ninja";

            Console.WriteLine($"Employee ID: {emp.ID} /nEmployee Name: {emp.Name}/nEmployee SS#: {emp.SSNumber}/nDate Created: {emp.EntryDate}");

            //Creating location to store your XML file
            string FilePath = "C:/Temp/";
            string FileName = "Samurai.xml";

            //TextWriter writer = new StreamWriter(FilePath + FileName);

            //XmlSerializer ser = new XmlSerializer(typef(Employee));

            //ser.Serialize(writer, emp);
            //writer.Close();

            Console.ReadLine();

        }
    }
}
