using RentalCarSystem.BusinessLogic.Abstactions;
using RentalCarSystem.DataAccessLayer;
using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using RentalCarSystem.DataAccessLayer.Repositories.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentalCarSystem.BusinessLogic.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {

        private CustomerContext _customerContext;

        public UnitOfWork(CustomerContext context)
        {
            _customerContext = context;
            CarsRepository = new CarsRepository(_customerContext);
            CompaniesRepository = new CompaniesRepository(_customerContext);
            CustomersRepository = new CustomersRepository(_customerContext);
            TransactionsRepository = new TransactionsRepository(_customerContext);


        }
        public ICarsRepository CarsRepository { get; private set; }

        public ICompaniesRepository CompaniesRepository { get; private set; }

        public ICustomersRepository CustomersRepository { get; private set; }

        public ITransactionsRepository TransactionsRepository { get; private set; }

        public int Complate()
        {
            return _customerContext.SaveChanges();
        }

        public void Dispose()
        {
            _customerContext.Dispose();
        }
    }
}
