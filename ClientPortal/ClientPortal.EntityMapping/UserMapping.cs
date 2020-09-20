using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.EntityMapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Table Mapping
            builder.ToTable("Users");
            // Primary Key
            builder.HasKey(t => t.Id);
            // Column Mappings
            builder.Property(t => t.UserName).HasColumnName("UserName").HasMaxLength(100).IsRequired();
            builder.Property(t => t.NormalizedUserName).HasColumnName("NormalizedUserName").HasMaxLength(100).IsRequired();
            builder.Property(t => t.Email).HasColumnName("Email").HasMaxLength(150).IsRequired();
            builder.Property(t => t.NormalizedEmail).HasColumnName("NormalizedEmail").HasMaxLength(150).IsRequired();
            builder.Property(t => t.EmailConfirmed).HasColumnName("EmailConfirmed").IsRequired();
            builder.Property(t => t.PasswordHash).HasColumnName("Password");
            builder.Property(t => t.SecurityStamp).HasColumnName("SecurityStamp");
            builder.Property(t => t.ConcurrencyStamp).HasColumnName("ConcurrencyStamp");
            builder.Property(t => t.PhoneNumberConfirmed).HasColumnName("PhoneNumberConfirmed").IsRequired();
            builder.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(50);
            builder.Property(t => t.TwoFactorEnabled).HasColumnName("TwoFactorEnabled");
            builder.Property(t => t.LockoutEnd).HasColumnName("LockoutEnd");
            builder.Property(t => t.LockoutEnabled).HasColumnName("LockoutEnabled");
            builder.Property(t => t.AccessFailedCount).HasColumnName("AccessFailedCount");
            builder.Property(t => t.FirstName).HasColumnName("FirstName").HasMaxLength(100);
            builder.Property(t => t.LastName).HasColumnName("LastName").HasMaxLength(100);
            builder.Property(t => t.ImageUrl).HasColumnName("PictureUrl");
            builder.Property(t => t.IsActive).HasColumnName("IsActive");

            builder.HasMany(e => e.UserRole)
               .WithOne(e => e.User)
               .HasForeignKey(ur => ur.UserId)
               .IsRequired();
        }
    }
}
