using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Printer.Printers;
using Task1.Printer.Interfaces;
using Task1.Tests.Helpers;
using OfficeOpenXml;
using Task1.DataAccess.Entities;

namespace Task1.Tests.PrinterTests
{
    [TestClass]
    public class ExcelPrinterTests
    {
        [TestMethod]
        public void TestExcelPrinter()
        {
            var path = "test.xlsx";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            IObjectPrinter printer = new ExcelPrinter();
            var objects = MockPersonsCreator.GetPersonsForMock();
            printer.PrintObjects(path, objects);
            Assert.IsTrue(File.Exists(path));

            using (ExcelPackage excel = new ExcelPackage(new FileInfo(path)))
            {
                var workbook = excel.Workbook;
                var worksheet = workbook.Worksheets.First();
                
                var properties = typeof(Person).GetProperties();
                List<string> fields = new List<string>();
                for (int i = 1; i <= properties.Length; i++)
                {
                    fields.Add(worksheet.GetValue<string>(1, i));
                }
                const int offset = 1;
                for (int i = 1; i <= objects.Count; i++)
                {
                    for (int j = 1; j <= properties.Count(); j++)
                    {
                        var value = worksheet.GetValue(i + offset, j);
                        var property = properties.FirstOrDefault(prop => prop.Name == fields[j - 1]);
                        var expectedVal = property?.GetValue(objects[i - 1]);
                        Assert.AreEqual(expectedVal, Convert.ChangeType(value, property.PropertyType));
                    }
                }
            }
        }
    }
}
