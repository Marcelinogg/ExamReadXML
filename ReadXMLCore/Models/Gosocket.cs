using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ReadXMLCore.Models
{
    [XmlRoot("gosocket")]
    public class Gosocket
    {
        [XmlElement("area", typeof(Area))]
        public List<Area> Areas { get; set; }
    }
}
