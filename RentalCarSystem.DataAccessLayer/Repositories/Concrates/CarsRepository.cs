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
    public class CarsRepository : Repository<Cars>, ICarsRepository
    {
        public CarsRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Cars> GetCarsWithCustomer()
        {
            return CustomerContext.Cars.Include("Customers").ToList();
        }

        public IEnumerable<Cars> GetTopCars(int count)
        {
            return CustomerContext.Cars.Take(count);
        }

        public CustomerContext CustomerContext { get { return _contentext as CustomerContext;  } }
    }
}
