using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using ReadXMLCore.Models;
using ReadXMLCore.Service;

namespace FunctionReadXML
{
    public static class FunctionMyTimer
    {
        [FunctionName("FunctionReadXML")]
        public static async Task Run([TimerTrigger("0 */30 * * * *", RunOnStartup =true)]TimerInfo myTimer, TraceWriter log)
        {
            log.Info("************************************************");
            log.Info($"Lectura de archivo XML a las: {DateTime.Now}");

            string filePath = "Content/gosocket.xml";
            Utils utils = new Utils();

            try
            {
                List<Area> areas = await utils.ParseXMLAsync(filePath);
                Result result = await utils.GetResultAsync(areas);

                log.Info(string.Format("{0} nodos AREA", result.TotalArea));
                log.Info(string.Format("{0} nodos AREA con más de 2 empleados", result.TotalAreaMoreTwoEmployees));

                log.Info("AREA\tTOTAL SALARIO:");

                foreach (string item in result.TotalSalaryByArea)
                {
                    log.Info(item);
                }
            } catch(Exception ex)
            {
                log.Error(ex.Message);
            }

            log.Info("************************************************");
        }
    }
}
