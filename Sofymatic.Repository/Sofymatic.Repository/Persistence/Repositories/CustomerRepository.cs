using Microsoft.EntityFrameworkCore;
using Sofymatic.Repository.Core.Domain;
using Sofymatic.Repository.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sofymatic.Repository.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        public SofymaticContext SofymaticContext
        {
            get { return Context as SofymaticContext; }
        }
    }
}
