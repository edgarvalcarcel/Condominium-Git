using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominium.Infrastructure.Persistence.Configurations
{
    public abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T>
     where T : class
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property<bool>("IsDeleted")
                .IsRequired()
                .HasDefaultValue(false);
            builder.Property<DateTime>("InsertDateTime")
                .IsRequired()
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();
            builder.Property<DateTime>("UpdateDateTime")
                .IsRequired()
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();
        }
    }
}
