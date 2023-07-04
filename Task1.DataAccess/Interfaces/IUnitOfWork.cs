using System;
using Task1.DataAccess.Entities;

namespace Task1.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Person> Persons { get; }
        void Save();
    }
}
