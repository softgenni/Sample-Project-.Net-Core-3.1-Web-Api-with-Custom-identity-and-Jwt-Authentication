using ClientPortal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientPortal.EntityMapping
{
    public class UserClaimMapping : IEntityTypeConfiguration<UserClaim>
    {
        public void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            // Table Map
            builder.ToTable("UserClaim");
            // Primary Key
            builder.HasKey(t => t.Id);
            // Column Mapping
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.ClaimType).HasColumnName("ClaimType");
            builder.Property(t => t.ClaimValue).HasColumnName("ClaimValue");
        }
    }
}
