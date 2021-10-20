using System;
using System.Data.Identity;
namespace UserApp
{
     class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext():base("DefaultConnection") { }
    }
}