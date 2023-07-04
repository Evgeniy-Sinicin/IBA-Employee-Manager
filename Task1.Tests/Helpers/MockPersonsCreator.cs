using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataAccess.Entities;

namespace Task1.Tests.Helpers
{
    public static class MockPersonsCreator
    {
        public static List<Person> GetPersonsForMock()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    City = "Гомель",
                    Country = "Беларусь",
                    Date = new System.DateTime(2019, 8, 29),
                    FirstName = "Акакий",
                    LastName = "Петренко",
                    MiddleName = "Леонидович"
                },

                new Person
                {
                    Id = 2,
                    City = "Гомель",
                    Country = "Беларусь",
                    Date = new System.DateTime(2019, 8, 30),
                    FirstName = "Сергей",
                    LastName = "Петров",
                    MiddleName = "Евгеньевич"
                },

                new Person
                {
                    Id = 3,
                    City = "Гомель",
                    Country = "Беларусь",
                    Date = new System.DateTime(2019, 8, 28),
                    FirstName = "Алексей",
                    LastName = "Петренков",
                    MiddleName = "Витальевич"
                }
            };
            return persons;
        }
    }
}
