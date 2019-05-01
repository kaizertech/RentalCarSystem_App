using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer.Repositories.Abstractions
{
    public interface ICarsRepository : IRepository<Cars>
    {
        IEnumerable<Cars> GetTopCars(int count);

        IEnumerable<Cars> GetCarsWithCustomer();
    }
}
