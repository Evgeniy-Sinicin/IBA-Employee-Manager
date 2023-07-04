using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Task1.DataAccess.EF;
using Task1.DataAccess.Entities;
using Task1.DataAccess.Interfaces;
using Task1.DataAccess.Repositories;
using Task1.Tests.Helpers;

namespace Task1.Tests.DataAccessTests
{
    [TestClass]
    public class EFDBTestsWithRealDB
    {
        [TestMethod]
        public void TestPersonsRepositoryWithRealDB()
        {
            var context = new ProjectContext("DbConnection", new TestDBInitializer());
            using (IUnitOfWork rep = new EFUnitOfWork(context))
            {
                var persons = rep.Persons.GetAll();
                Assert.AreEqual(persons.Count(), 3);

                var newPerson = new Person
                {
                    City = "Гомель",
                    Country = "Беларусь",
                    Date = new System.DateTime(2019, 8, 27),
                    FirstName = "Вася",
                    LastName = "Пупкин",
                    MiddleName = "Александрович"
                };
                rep.Persons.Create(newPerson);
                rep.Save();
                Assert.AreEqual(persons.Count(), 4);

                var person = rep.Persons.Find(p => p.LastName == "Пупкин").FirstOrDefault();
                Assert.IsNotNull(person);

                person.LastName = "Попкин";
                rep.Persons.Update(person);
                Assert.AreEqual(person.LastName, rep.Persons.Find(p => p.Id == person.Id).FirstOrDefault().LastName);

                var person2 = rep.Persons.Get(person.Id);
                Assert.IsNotNull(person2);

                var id = person.Id;
                rep.Persons.Delete(id);
                rep.Save();

                var deletedPerson = rep.Persons.Get(id);
                Assert.IsNull(deletedPerson);
            }
        }
    }
}
