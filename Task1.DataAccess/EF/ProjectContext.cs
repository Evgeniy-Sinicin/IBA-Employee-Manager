using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.DataAccess.Entities;

namespace Task1.DataAccess.EF
{
    public class ProjectContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public ProjectContext(string connectionString, IDatabaseInitializer<ProjectContext> initializer) : base(connectionString)
        {
            Database.SetInitializer(initializer);
        }

        public ProjectContext(string connectionString) : base(connectionString)
        {
        }
    }
}
