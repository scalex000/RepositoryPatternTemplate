using Sofymatic.Repository.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Core.Repositories
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        IEnumerable<Customer> GetGrandCustomers(int count);
    }
}
