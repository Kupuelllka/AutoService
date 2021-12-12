using System;
using System.Data.Entity;
namespace UsersApp
{
     class ApplicationContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public ApplicationContext():base("DefaultConnection") { }
    }
}