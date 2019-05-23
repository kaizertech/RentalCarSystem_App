using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCarSystem.DataAccessLayer.Repositories.Concrates;

namespace RentalCarSystem.DataAccessLayer.Repositories.Abstractions
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(RentACarContext context) : base(context)
        {

        }
        protected RentACarContext RentACarContext { get { return _context as RentACarContext; } }
    }
}
