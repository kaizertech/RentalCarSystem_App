using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;

namespace RentalCarSystem.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private RentACarContext _rentACarContext;
        public UnitOfWork(RentACarContext context)
        {
            this._rentACarContext = context;
            carRepository = new CarRepository(_rentACarContext);
            cartrackingRepository = new CartrackingRepository(_rentACarContext);
            companyRepository = new CompanyRepository(_rentACarContext);
            customerRepository = new CustomerRepository(_rentACarContext);
            personRepository = new PersonRepository(_rentACarContext);
            rentalRepository = new RentalRepository(_rentACarContext);
            roleRepository = new RoleRepository(_rentACarContext);
            spendingRepository = new SpendingRepository(_rentACarContext);
            spendingTypeRepository = new SpendingTypeRepository(_rentACarContext);
            userRepository = new UserRepository(_rentACarContext);

    }


        public ICarRepository carRepository { get; private set; }
        public ICartrackingRepository cartrackingRepository { get; private set; }
        public ICompanyRepository companyRepository { get; private set; }
        public ICustomerRepository customerRepository { get; private set; }
        public IPersonRepository personRepository { get; private set; }
        public IRentalRepository rentalRepository { get; private set; }
        public IRoleRepository roleRepository { get; private set; }
        public ISpendingRepository spendingRepository { get; private set; }
        public ISpendingTypeRepository spendingTypeRepository { get; private set; }
        public IUserRepository userRepository { get; private set; }

        public int Commit()
        {
            return _rentACarContext.SaveChanges();
        }

        public void Dispose()
        {
            _rentACarContext.Dispose();
        }
    }
}
