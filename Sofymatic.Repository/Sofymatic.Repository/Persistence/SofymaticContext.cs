using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Sofymatic.Repository.Core.Domain;
using Sofymatic.Repository.Persistence.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Persistence
{
    public class SofymaticContext : DbContext
    {
        //public SofymaticContext(): base("name=SofymaticContext")
        //{
        //    this.Configuration.LazyLoadingEnabled = false;
        //}
        public SofymaticContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}
