﻿using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer.Repositories.Abstractions
{
    public interface ICustomersRepository : IRepository<Customers>
    {
        IEnumerable<Customers> GetCustomersWithCars();

        IEnumerable<Customers> GetCustomerWithCompanies();
    }
}
