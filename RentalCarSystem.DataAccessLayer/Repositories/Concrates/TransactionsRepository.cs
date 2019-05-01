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
    public class TransactionsRepository : Repository<Transactions>, ITransactionsRepository
    {
        public TransactionsRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Transactions> GetTopTransaction(int count)
        {
            return CustomerContext.Transactions.Take(count);
        }

        public CustomerContext CustomerContext { get { return _contentext as CustomerContext; } }
    }
}
