using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_Deep_Dive._04_RealWorld
{
    public class RealWorld
    {
        public static void Run()
        {
            // Consuming APIs with Unknown or Evolving Schema

            string json = "{ \"user\": { \"name\": \"Alice\", \"age\": 30 } }";
            dynamic result = JsonConvert.DeserializeObject(json);
            Console.WriteLine(result.user.name); // No model class needed

            // Excel Automation (COM Interop)

            dynamic excelApp = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
            excelApp.Visible = true;
            dynamic workbook = excelApp.Workbooks.Add();
            dynamic sheet = workbook.ActiveSheet;
            sheet.Cells[1, 1].Value = "Dynamic Excel!";

        }
    }
}
