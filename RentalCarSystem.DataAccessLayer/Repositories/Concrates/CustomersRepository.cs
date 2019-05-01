using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer.Repositories.Concrates
{
    public class CustomersRepository : Repository<Customers>, ICustomersRepository
    {
        public CustomersRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Customers> GetCustomersWithCars()
        {
            return CustomerContext.Customers.Include("Cars").ToList();
        }

        public IEnumerable<Customers> GetCustomerWithCompanies()
        {
            return CustomerContext.Customers.Include("Companies").ToList();
        }

        public CustomerContext CustomerContext { get { return _contentext as CustomerContext; } }
    }
}
