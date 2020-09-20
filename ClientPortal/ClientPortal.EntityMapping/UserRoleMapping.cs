using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class UserRoleMapping : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Table Map
            builder.ToTable("UserRole");
            // Primary Key
            builder.HasKey(t => new { t.UserId, t.RoleId });
            // column Mapping

            builder.Property<string>(t => t.UserId).HasColumnName("UserId");
            builder.Property<string>(t => t.RoleId).HasColumnName("RoleId");
        }
    }
}
