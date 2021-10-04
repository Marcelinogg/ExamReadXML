using System;
using System.Collections.Generic;
using System.Text;

namespace ReadXMLCore.Models
{
    public class Result
    {
        public int TotalArea { get; set; }
        public int TotalAreaMoreTwoEmployees { get; set; }
        public List<string> TotalSalaryByArea { get; set; }
    }
}
