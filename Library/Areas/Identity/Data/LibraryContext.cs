using Library.Areas.Identity.Data;
using Library.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data;

public class LibraryContext : IdentityDbContext<LibraryUser>
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public DbSet<Books> Books { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Reserve> Reserve { get; set; }


    public DbSet<LibraryUser> User { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                Name = "User",
                NormalizedName = "USER"
            }
        );
        //Seed Admin and User
        var hasher = new PasswordHasher<LibraryUser>();
        builder.Entity<LibraryUser>().HasData(
            new LibraryUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                UserName = "admin@admin.admin",
                NormalizedUserName = "ADMIN@ADMIN.ADMIN",
                PasswordHash = hasher.HashPassword(null, "admin"),
                Email = "admin@admin.admin",
                NormalizedEmail = "ADMIN@ADMIN.ADMIN",
                PhoneNumber = "123456789",
                FirstName = "Admin",
                LastName = "Admin"
            },
            new LibraryUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                UserName = "user@user.user",
                NormalizedUserName = "USER@USER.USER",
                PasswordHash = hasher.HashPassword(null, "user"),
                Email = "user@user.user",
                NormalizedEmail = "USER@USER.USER",
                PhoneNumber = "987654321",
                FirstName = "User",
                LastName = "User"
            }
         );
        //Add roles for Admin and User
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
            },
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"
            }
         );

        builder.Entity<Books>().HasData(
           new Books
           {
               ID = 1,
               Title = "Romeo and Juliet",
               Author = "William Shakespeare",
               BookEditionYear = 2011
           },
           new Books
           {
               ID = 2,
               Title = "Quo vadis",
               Author = "Henryk Sienkiewicz",
               BookEditionYear = 2002
           },
           new Books {
               ID = 3,
               Title = "Quo vadis",
               Author = "Henryk Sienkiewicz",
               BookEditionYear = 2012
           },
           new Books
           {
               ID = 4,
               Title = "Balladyna",
               Author = "Juliusz Słowacki",
               BookEditionYear = 2014
           },
           new Books
           {
               ID = 5,
               Title = "Kordian",
               Author = "Juliusz Słowacki",
               BookEditionYear = 2021
           },
           new Books
           {
               ID = 6,
               Title = "Ojciec Goriot",
               Author = "Honoré de Balzac",
               BookEditionYear = 2018
           },
           new Books
           {
               ID = 7,
               Title = "Ferdydurke",
               Author = "Witold Gombrowicz",
               BookEditionYear = 2013
           }

           );
    }


}
