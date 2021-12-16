using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BLL;

namespace DAL_EntityFramework_
{
    class DBContext : DbContext
    {
        public DBContext() : base ("DBContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
