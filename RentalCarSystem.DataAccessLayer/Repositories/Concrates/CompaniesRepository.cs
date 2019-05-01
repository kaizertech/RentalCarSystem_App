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
    public class CompaniesRepository : Repository<Companies>, ICompaniesRepository
    {
        public CompaniesRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Companies> GetCompaniesWithCars()
        {
            return CustomerContext.Companies.Include("Cars").ToList();
        }

        public IEnumerable<Companies> GetTopCompanies(int count)
        {
            return CustomerContext.Companies.Take(count);
        }

        public CustomerContext CustomerContext { get { return _contentext as CustomerContext; } }
    }
}
