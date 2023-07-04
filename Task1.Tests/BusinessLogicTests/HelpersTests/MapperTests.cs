using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1.Extractor.Dtos;
using Task1.BusinessLogic.Helpers;
using Task1.DataAccess.Entities;

namespace Task1.Tests.BusinessLogicTests.HelpersTests
{
    [TestClass]
    public class MapperTests
    {
        [TestMethod]
        public void MapperTest()
        {
            var personDto = new PersonDto
            {
                City = "Гомель",
                Country = "Беларусь",
                Date = new System.DateTime(2019, 8, 29),
                FirstName = "Акакий",
                LastName = "Петренко",
                MiddleName = "Леонидович"
            };

            var person = Mapper.Map<PersonDto, Person>(personDto);
            
            Assert.AreEqual(personDto.Date, person.Date);
            Assert.AreEqual(personDto.FirstName, person.FirstName);
            Assert.AreEqual(personDto.LastName, person.LastName);
            Assert.AreEqual(personDto.MiddleName, person.MiddleName);
            Assert.AreEqual(personDto.City, person.City);
            Assert.AreEqual(personDto.Country, person.Country);
        }
    }
}
