using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiBackEnd.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext() : base("Employees") { }
        public DbSet<Employee> Employees { get; set; }
    }
    
}