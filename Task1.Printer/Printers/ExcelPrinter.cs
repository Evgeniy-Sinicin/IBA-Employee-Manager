using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Printer.Interfaces;
using OfficeOpenXml;
using System.IO;

namespace Task1.Printer.Printers
{
    public class ExcelPrinter : IObjectPrinter
    {
        public void PrintObjects<T>(string path, IEnumerable<T> objects)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                var type = typeof(T);
                excel.Workbook.Worksheets.Add(type.Name);
                var properties = type.GetProperties();
                var headerRow = new List<string[]>()
                {
                    properties.Select(t => t.Name).ToArray()
                };
                const int symbolOffset = 64;
                string headerRange = "A1:" + Char.ConvertFromUtf32(properties.Length + symbolOffset) + "1";
                
                var worksheet = excel.Workbook.Worksheets[type.Name];
                
                worksheet.Cells[headerRange].LoadFromArrays(headerRow);
                const int stringNumberOffset = 2;
                for (int i = 0; i < objects.Count(); i++)
                {
                    var range = $"A{i + stringNumberOffset}:{Char.ConvertFromUtf32(properties.Length + symbolOffset)}{i + stringNumberOffset}";
                    var values = properties.Select(prop => prop.GetValue(objects.ElementAt(i)).ToString()).ToArray();
                    worksheet.Cells[range].LoadFromArrays(new List<string[]>() { values });
                }

                FileInfo excelFile = new FileInfo(path);
                excel.SaveAs(excelFile);
            }
        }
    }
}
