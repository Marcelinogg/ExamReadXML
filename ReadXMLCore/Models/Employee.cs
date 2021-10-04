using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ReadXMLCore.Models
{
    public class Employee
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("salary")]
        public decimal Salary { get; set; }

        [XmlAttribute("jobTitle")]
        public string JobTitle { get; set; }
    }
}
