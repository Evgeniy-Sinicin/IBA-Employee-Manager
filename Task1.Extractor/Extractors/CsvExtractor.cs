using System;
using System.Collections.Generic;
using System.IO;
using Task1.Extractor.Dtos;
using Task1.Extractor.Interfaces;

namespace Task1.Extractor.Extractors
{
    public class CsvExtractor : IExtractor
    {
        #region Public Methods
        public IEnumerable<PersonDto> Extract(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();
            try
            {
                using (var stream = File.OpenText(path))
                {
                    var results = new List<PersonDto>();
                    while (!stream.EndOfStream)
                    {
                        var line = stream.ReadLine();
                        var person = ParseLineToPerson(line);
                        results.Add(person);
                    }
                    return results;
                }
            }
            catch (Exception)
            {
                throw new Exception("Error! The selected file could not be loaded.");
            }
        }
        #endregion

        #region Private Methods
        private PersonDto ParseLineToPerson(string line)
        {
            var values = line.Split(new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (values.Length != 6)
                throw new FormatException("Incorrect file format");
            var person = new PersonDto();
            person.Date = Convert.ToDateTime(values[0]);
            person.FirstName = values[1];
            person.LastName = values[2];
            person.MiddleName = values[3];
            person.City = values[4];
            person.Country = values[5];
            return person;
        }
        #endregion
    }
}
