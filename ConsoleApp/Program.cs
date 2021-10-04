using ReadXMLCore.Models;
using ReadXMLCore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string filePath = "Content/gosocket.xml";
            Utils utils = new Utils();

            List<Area> areas = utils.ParseXML(filePath);
            Result result = utils.GetResult(areas);

            Console.WriteLine($"{result.TotalArea} nodos AREA");
            Console.WriteLine($"{result.TotalAreaMoreTwoEmployees} nodos AREA con más de 2 empleados");
            Console.WriteLine("AREA\tTOTAL SALARIO:");

            foreach(string item in result.TotalSalaryByArea)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
