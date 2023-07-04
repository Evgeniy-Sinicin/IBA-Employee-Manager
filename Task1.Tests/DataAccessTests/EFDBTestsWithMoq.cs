using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Task1.DataAccess.Entities;
using Task1.DataAccess.Interfaces;
using Task1.Tests.Helpers;

namespace Task1.Tests.DataAccessTests
{
    [TestClass]
    public class EFDBTestsWithMoq
    {
        [TestMethod]
        public void TestPersonsRepositoryWithMocks()
        {
            var mock = new Mock<IRepository<Person>>();
            var persons = MockPersonsCreator.GetPersonsForMock();
            var person = new Person
            {
                Id = 4,
                City = "Гомель",
                Country = "Беларусь",
                Date = new System.DateTime(2019, 8, 30),
                FirstName = "Евгений",
                LastName = "Петренко",
                MiddleName = "Леонидович"
            };
            mock.Setup(p => p.Create(person)).Callback(() => 
                {
                    persons.Add(person);
                }
            );
            var newName = "asdfasfa";
            mock.Setup(p => p.GetAll()).Returns(persons);
            //mock.Setup(p => p.Get(4)).Returns(mock.Object.GetAll().FirstOrDefault(t => t.Id == 4));
            mock.Setup(p => p.Get(4)).Returns(person);
            mock.Setup(p => p.Update(person)).Callback(() =>
            {
                person.LastName = newName;
            });
            mock.Setup(p => p.Delete(person.Id)).Callback(() =>
            {
                persons.Remove(persons.FirstOrDefault(t => t.Id == person.Id));
            });
            mock.Object.Create(person);
            var firstPerson = mock.Object.Get(4);
            Assert.AreEqual(firstPerson.Id, 4);
            var count = mock.Object.GetAll().Count();
            Assert.AreEqual(count, 4);
            mock.Object.Update(person);
            Assert.AreEqual(person.LastName, newName);
            mock.Object.Delete(person.Id);
            Assert.AreEqual(mock.Object.GetAll().Count(), 3);
        }
    }
}
