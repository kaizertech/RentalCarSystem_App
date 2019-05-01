using RentalCarSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarSystem.DataAccessLayer.Repositories.Abstractions
{
    public interface ITransactionsRepository : IRepository<Transactions>
    {
        IEnumerable<Transactions> GetTopTransaction(int count);
    }
}
