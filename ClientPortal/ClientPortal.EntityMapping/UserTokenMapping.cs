using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class UserTokenMapping : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            // Table Map
            builder.ToTable("UserToken");
            // Primary Key
            builder.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            // Column Mapping
            builder.Property<string>(t => t.UserId).HasColumnName("UserId");
            builder.Property<string>(t => t.LoginProvider).HasColumnName("LoginProvider");
            builder.Property<string>(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
