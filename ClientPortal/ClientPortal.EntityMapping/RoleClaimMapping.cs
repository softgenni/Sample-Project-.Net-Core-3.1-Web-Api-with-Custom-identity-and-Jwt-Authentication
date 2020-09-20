using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class RoleClaimMapping: IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            // Table Map
            builder.ToTable("RoleClaim");
            // Primary Key
            builder.HasKey(t => t.Id);
            // Column Mapping
            builder.Property(t => t.RoleId).HasColumnName("RoleId");
            builder.Property(t => t.ClaimType).HasColumnName("ClaimType");
            builder.Property(t => t.ClaimValue).HasColumnName("ClaimValue");
        }
    }
}
