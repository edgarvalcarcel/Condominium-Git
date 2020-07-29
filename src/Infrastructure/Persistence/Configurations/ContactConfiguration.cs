
using Condominium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Condominium.Infrastructure.Persistence.Configurations
{
    public class ContactConfiguration : BaseEntityTypeConfiguration<Contact>, IEntityTypeConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(t => t.Phone)
              .HasMaxLength(20)
              .IsRequired();

            builder.Property(t => t.Relationship)
            .HasMaxLength(60)
            .IsRequired();

            builder.Property(t => t.Email)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(t => t.Address)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(t => t.City)
            .HasMaxLength(60)
            .IsRequired();

            base.Configure(builder);
        }
    }
}
