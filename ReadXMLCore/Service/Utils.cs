using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ReadXMLCore.Models;

namespace ReadXMLCore.Service
{
    public class Utils : IUtils
    {
        public Result GetResult(List<Area> areas)
        {
            Task<Result> task = GetResultAsync(areas);
            task.Wait();

            return task.Result;
        }

        public async Task<Result> GetResultAsync(List<Area> areas)
        {
            return await Task.Run(
                ()=> new Result()
                {
                    TotalArea = areas.Count,
                    TotalAreaMoreTwoEmployees = areas.Count(a => a.Employees.Count > 2),
                    TotalSalaryByArea = areas.Select(a =>$"{a.Name}|{a.Employees.Sum(e => e.Salary)}").ToList()
                });
        }

        public List<Area> ParseXML(string filePath)
        {
            Task<List<Area>> task = ParseXMLAsync(filePath);
            task.Wait();

            return task.Result;
        }

        public async Task<List<Area>> ParseXMLAsync(string filePath)
        {
            Gosocket gosocket = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Gosocket));
                gosocket = (Gosocket)serializer.Deserialize(reader);
            }

            return await Task.Run(()=> gosocket.Areas);
        }
    }
}
