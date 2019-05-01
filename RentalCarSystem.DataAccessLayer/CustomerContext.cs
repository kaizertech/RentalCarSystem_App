using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerContext")
        {

        }
        public DbSet<Cars> Cars { get; set; }

        public DbSet<Companies> Companies { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
