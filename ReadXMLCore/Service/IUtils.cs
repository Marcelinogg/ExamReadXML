using ReadXMLCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ReadXMLCore.Service
{
    interface IUtils
    {
        List<Area> ParseXML(string filePath);

        Result GetResult(List<Area> areas);

        Task<List<Area>> ParseXMLAsync(string filePath);

        Task<Result> GetResultAsync(List<Area> areas);
    }
}
