using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer
{
    public class RentACarContext : DbContext
    {
        public RentACarContext() : base("RentACarContext")
        {
            
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet <Spending> Spendings { get; set; }
        public DbSet<SpendingType> SpendingTypes { get; set; }
        public DbSet<Cartracking> Cartrackings { get; set; }
        public DbSet<Role> Roles { get; set; }
        
    }
}
