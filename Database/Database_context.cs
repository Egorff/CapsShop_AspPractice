using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database
{
    public class Database_context : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        #region Prop
        public DbSet<Cap> Shop { get; set; }
        public DbSet<User> CustomUsers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Postoffice> Postofices { get; set; }
        #endregion

        #region ctor
        public Database_context(DbContextOptions opt):base(opt)
        {
            
        }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Model buildings
            builder.Entity<User>().HasMany(k => k.Bin).WithOne(k => k.User).HasForeignKey(fk => fk.UserId);

            builder.Entity<Adress>().HasOne(k => k.PostOffice).WithOne(k => k.Adress).HasForeignKey<Postoffice>
                (fk => fk.AdressId);

            builder.Entity<User>().HasOne(k => k.Adress).WithOne(k => k.User).HasForeignKey<Adress>(fk => fk.UserId);
            #endregion

            builder.Entity<User>().HasData(
                new User()
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
