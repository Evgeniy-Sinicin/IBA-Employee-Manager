using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Extractor.Extractors;
using Task1.Extractor.Interfaces;
using Task1.Tests.Properties;

namespace Task1.Tests.ExtractorTests
{
    [TestClass]
    public class CsvExtractorTests
    {
        [TestMethod]
        public void TestCsvExtractorExtractFromExistingFileWithThreeRecords()
        {
            IExtractor csvExtractor = new CsvExtractor();
            string pathToCsv = FilesPaths.CsvFile;
            var isPathExitst = File.Exists(pathToCsv);
            var records = csvExtractor.Extract(pathToCsv);
            
            Assert.IsNotNull(records);
            Assert.AreEqual(3, records.Count());
            Assert.IsTrue(records.Any(rec => rec.FirstName == "Name1"));
        }

        [TestMethod]
        public void TestCsvExtractorExtractFromNotExistingFile()
        {
            IExtractor csvExtractor = new CsvExtractor();
            var pathToCsv = FilesPaths.NotExistingCsvFile;
            Assert.ThrowsException<FileNotFoundException>(() => csvExtractor.Extract(pathToCsv));
        }
    }
}
