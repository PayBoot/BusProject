using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("server = (local); Initial Catalog = EmployeeTestDb; Integrated Security= true")
        {
        }
        public DbSet<Employee> Employeetable { get; set; }
    }
}