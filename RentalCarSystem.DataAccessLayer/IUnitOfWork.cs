using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;

namespace RentalCarSystem.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository carRepository { get; } 
        ICartrackingRepository cartrackingRepository { get; }
        ICompanyRepository companyRepository { get; }
        ICustomerRepository customerRepository { get; }
        IPersonRepository personRepository { get; }
        IRentalRepository rentalRepository { get; }
        IRoleRepository roleRepository { get; }
        ISpendingRepository spendingRepository { get; }
        ISpendingTypeRepository spendingTypeRepository { get; }
        IUserRepository userRepository { get; }

        int Commit();

    }
}
