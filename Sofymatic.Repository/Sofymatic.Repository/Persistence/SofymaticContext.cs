﻿using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Sofymatic.Repository.Core.Domain;
using Sofymatic.Repository.Persistence.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.FileExtensions;

namespace Sofymatic.Repository.Persistence
{
    public class SofymaticContext : DbContext
    {
        public SofymaticContext()
        {

        }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Sofymatic;Trusted_Connection=True;MultipleActiveREsultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
    }
}
