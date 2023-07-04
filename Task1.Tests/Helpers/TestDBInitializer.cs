using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataAccess.EF;
using Task1.DataAccess.Entities;

namespace Task1.Tests.Helpers
{
    public class TestDBInitializer : DropCreateDatabaseAlways<ProjectContext>
    {
        protected override void Seed(ProjectContext db)
        {
            db.Persons.Add(new Person
            {
                City = "Гомель",
                Country = "Беларусь",
                Date = new System.DateTime(2019, 8, 29),
                FirstName = "Акакий",
                LastName = "Петренко",
                MiddleName = "Леонидович"
            });

            db.Persons.Add(new Person
            {
                City = "Гомель",
                Country = "Беларусь",
                Date = new System.DateTime(2019, 8, 30),
                FirstName = "Сергей",
                LastName = "Петров",
                MiddleName = "Евгеньевич"
            });

            db.Persons.Add(new Person
            {
                City = "Гомель",
                Country = "Беларусь",
                Date = new System.DateTime(2019, 8, 28),
                FirstName = "Алексей",
                LastName = "Петренков",
                MiddleName = "Витальевич"
            });

            db.SaveChanges();
        }
    }
}
