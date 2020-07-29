using System;
using System.Collections.Generic;
using System.Text;
using Condominium.Domain.Common;
using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Condominium.Infrastructure.Persistence.Configurations
{

    public class AuditableEntityConfiguration : IEntityTypeConfiguration<AuditableEntity>
    {
        public virtual void Configure(EntityTypeBuilder<AuditableEntity> builder)
        {
            builder.Property(t => t.CreatedBy)
                .HasMaxLength(60)
                .IsRequired();

             builder.Property<DateTime>("Created")
               .HasDefaultValueSql("SYSDATETIME()").ValueGeneratedOnAdd()
               .IsRequired();

            builder.Property(t => t.LastModifiedBy)
               .HasMaxLength(60)
               .IsRequired();

            builder.Property<DateTime>("LastModified")
               .HasDefaultValueSql("SYSDATETIME()").ValueGeneratedOnUpdate()
               .IsRequired();
        }
    } 
}
