using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ReadXMLCore.Models
{
    public class Area
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("description")]
        public string Desciption { get; set; }

        [XmlArray("employees")]
        [XmlArrayItem("employee", typeof(Employee))]
        public List<Employee> Employees { get; set; }
    }
}
