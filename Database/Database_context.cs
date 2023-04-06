using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class Database_context : IdentityDbContext<IdentityUser<Guid>, IdentityRole<Guid>, Guid>
    {
        #region Prop
        
        #endregion

        #region ctor
        public Database_context(DbContextOptions opt):base(opt)
        {
            
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUser<Guid>>().HasData(
                new IdentityUser<Guid>()
                {
                    Id = Guid.Parse("39cbcf72-56b0-4f84-aee2-3486997654b8"),
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "wrestler000ua@gmail.com",
                    NormalizedEmail = "WRESTLER000UA@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = new PasswordHasher<IdentityUser<Guid>>().HashPassword(null, "123"),
                    SecurityStamp = string.Empty
                }
                );

            builder.Entity<IdentityRole<Guid>>().HasData(
                new IdentityRole<Guid>()
                {
                    Id = Guid.Parse("00c4f9c8-0308-428c-9679-4de44beea0fb"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole<Guid>()
                {
                    Id = Guid.Parse("5975e843-abb8-4580-9af0-7b5f4e9c67e6"),
                    Name = "User",
                    NormalizedName = "USER"
                }
                );

            builder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("00c4f9c8-0308-428c-9679-4de44beea0fb"),
                    UserId = Guid.Parse("39cbcf72-56b0-4f84-aee2-3486997654b8")
                }
                );
            base.OnModelCreating(builder);
        }
        #endregion
    }
}
