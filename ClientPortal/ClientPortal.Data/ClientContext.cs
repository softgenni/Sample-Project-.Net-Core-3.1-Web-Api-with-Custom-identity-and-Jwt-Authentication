using ClientPortal.Entities;
using ClientPortal.EntityMapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClientPortal.Data
{
    public class ClientContext: IdentityDbContext<User, Role, string, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ClientContext(DbContextOptions<ClientContext> options)
           : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<UserClaim> UserClaim { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserMapping());
            builder.ApplyConfiguration(new RoleMapping());
            builder.ApplyConfiguration(new UserRoleMapping());
            builder.ApplyConfiguration(new RoleClaimMapping());
            builder.ApplyConfiguration(new UserClaimMapping());
            builder.ApplyConfiguration(new UserLoginMapping());
            builder.ApplyConfiguration(new UserTokenMapping());
        }
    }
}
