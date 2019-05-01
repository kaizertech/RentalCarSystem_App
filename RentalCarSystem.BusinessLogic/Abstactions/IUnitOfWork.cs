using RentalCarSystem.DataAccessLayer.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.BusinessLogic.Abstactions
{
    public interface IUnitOfWork : IDisposable
    {
        ICarsRepository CarsRepository { get; }
        ICompaniesRepository CompaniesRepository { get; }
        ICustomersRepository CustomersRepository { get; }
        ITransactionsRepository TransactionsRepository { get; }

        int Complate();
    }
}
