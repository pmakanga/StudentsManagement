using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentsManagement.Shared.Models;

namespace StudentsManagement.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("tb_Users");
            builder.Entity<IdentityRole>().ToTable("tb_Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("tb_UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("tb_UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("tb_UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("tb_RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("tb_UserTokens");

            builder.Entity<Student>().ToTable("tb_Students");

        }

        public DbSet<Student> Students { get; set; }
    }
}
