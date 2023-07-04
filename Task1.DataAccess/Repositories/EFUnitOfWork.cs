using System;
using Task1.DataAccess.EF;
using Task1.DataAccess.Entities;
using Task1.DataAccess.Interfaces;

namespace Task1.DataAccess.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ProjectContext db { get; set; }
        private PersonRepository personRepository { get; set; }
        private bool dispose = false;

        public EFUnitOfWork(string connectionString)
        {
            db = new ProjectContext(connectionString);
        }
        public EFUnitOfWork(ProjectContext context)
        {
            db = context;
        }

        public IRepository<Person> Persons
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new PersonRepository(db);
                }

                return personRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!dispose)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                dispose = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
