using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class UserLoginMapping : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            // Table Map
            builder.ToTable("UserLogin");
            // Primary Key
            builder.HasKey(t => new { t.LoginProvider, t.ProviderKey });
            // Column Mapping
            builder.Property<string>(t => t.LoginProvider).HasColumnName("LoginProvider");
            builder.Property<string>(t => t.ProviderKey).HasColumnName("ProviderKey");
            builder.Property(t => t.ProviderDisplayName).HasColumnName("ProviderDisplayName");
            builder.Property(t => t.UserId).HasColumnName("UserId").IsRequired(); ;
        }
    }
}
