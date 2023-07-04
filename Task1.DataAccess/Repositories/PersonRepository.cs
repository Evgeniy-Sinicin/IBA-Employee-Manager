using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataAccess.EF;
using Task1.DataAccess.Entities;
using Task1.DataAccess.Interfaces;

namespace Task1.DataAccess.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        public PersonRepository(ProjectContext context)
        {
            db = context;
        }

        private ProjectContext db { get; set; }

        public void Create(Person item)
        {
            db.Persons.Add(item);
        }

        public void Delete(int id)
        {
            var person = db.Persons.Find(id);
            if (person != null)
            {
                db.Persons.Remove(person);
            }
        }

        public IEnumerable<Person> Find(Func<Person, Boolean> predicate)
        {
            return db.Persons.Where(predicate).ToList();
        }

        public Person Get(int id)
        {
            return db.Persons.Find(id);
        }

        public IEnumerable<Person> GetAll()
        {
            return db.Persons;
        }

        public void Update(Person item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
