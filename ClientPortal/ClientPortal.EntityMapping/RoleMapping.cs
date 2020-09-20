using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            // Table Map
            builder.ToTable("Roles");
            // Primary Key
            builder.HasKey(t => t.Id);
            // Column Mapping
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
            builder.Property(t => t.NormalizedName).HasColumnName("NormalizedName");

            builder.HasMany(e => e.UserRole)
                       .WithOne(x => x.Role)
                       .HasForeignKey(ur => ur.RoleId)
                       .IsRequired();
            builder.HasMany<RoleClaim>()
                .WithOne()
                .HasForeignKey(rc => rc.RoleId)
                .IsRequired();
        }
    }
}
