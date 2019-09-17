using Sofymatic.Repository.Core;
using Sofymatic.Repository.Core.Repositories;
using Sofymatic.Repository.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Persistence
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly SofymaticContext _context;

        public UnitOfWork(SofymaticContext context)
        {
            _context = context;

            //put here your repository 
            Customers = new CustomerRepository(_context);
        }

        public ICustomerRepository Customers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
