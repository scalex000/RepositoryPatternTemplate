using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sofymatic.Repository.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sofymatic.Repository.Persistence.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
            builder.Property(c => c.CustomerId)
                .IsRequired();
            builder.Property(c => c.Name)
                .HasMaxLength(50);
            builder.Property(c => c.LastName)
                .HasMaxLength(50);
                
        }
    }
}
