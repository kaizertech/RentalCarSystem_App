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

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Veri tabanı ilişkileri kurma çelınç :D
            modelBuilder.Entity<Transactions>()
                .HasRequired<Customers>(x => x.Customers)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.Musteri_id);

            modelBuilder.Entity<Transactions>()
                .HasRequired<Cars>(x => x.Cars)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.Araba_id);

            modelBuilder.Entity<Cars>()
                .HasRequired<Companies>(x => x.Companies)
                .WithMany(x => x.Cars)
                .HasForeignKey(x => x.Sirket_id);
                

            base.OnModelCreating(modelBuilder);
        }*/

    }
}
