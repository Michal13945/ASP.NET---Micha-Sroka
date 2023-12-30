using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }

        private string DbPath { get; set; }

        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "contacts.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string ADMIN_ID = "d1dcfe34-d3d7-4aad-bfcf-e950e069160d";
            string USER_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ID = "2e6e1e6d-4350-45c0-9749-16185fe88d44";

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole[]
            {
                new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    Id = ADMIN_ROLE_ID,
                    ConcurrencyStamp = ADMIN_ROLE_ID
                },
                new IdentityRole
                {
                    Name = "user",
                    NormalizedName = "USER",
                    Id = USER_ROLE_ID,
                    ConcurrencyStamp = USER_ROLE_ID
                }
            });

            var admin = new IdentityUser
            {
                Id = ADMIN_ID,
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "admin@wsei.edu.pl",
                NormalizedUserName = "ADMIN@WSEI.EDU.PL",
                PasswordHash = "AQAAAAEAACcQAAAAEHpbGMsQh4su/LSWHcBGLnS1Rdp22Xsvh4qKGMnCGnzXyf4bPbYaULZPES93QyyvJg==",
                SecurityStamp = "TTV56G4THE2H6K2VTTKXTITTO4R5NE44",
                ConcurrencyStamp = "ea74cb17-6b76-4db9-9352-16e8a3aec765"
            };
            var user = new IdentityUser
            {
                Id = USER_ID,
                Email = "user@wsei.edu.pl",
                NormalizedEmail = "USER@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "user@wsei.edu.pl",
                NormalizedUserName = "USER@WSEI.EDU.PL",
                PasswordHash = "AQAAAAEAACcQAAAAEAmYQkrm2RARVIRpa+In6x2bEU5QHct2SsKJwpVabSjnkDTKZd4xmAMRxz/uusvn8w==",
                SecurityStamp = "KH22K26VMALPMHUY4FNJDLAPZNYCCE32",
                ConcurrencyStamp = "024298f7-b381-4a52-abe3-3b52ab0abc75"
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            //admin.PasswordHash = ph.HashPassword(admin, "1234abcd!@#$ABCD");

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser[]
            {
                admin,
                user
            });

            modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID
                },
            });


            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(e => e.Address);

            modelBuilder.Entity<ContactEntity>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>().HasData(
                 new OrganizationEntity()
                 {
                     Id = 1,
                     Title = "WSEI",
                     Nip = "83492384",
                     Regon = "13424234",
                 },
                 new OrganizationEntity()
                 {
                     Id = 2,
                     Title = "Firma",
                     Nip = "2498534",
                     Regon = "0873439249",
                 }
             );

            modelBuilder.Entity<ContactEntity>().HasData(
               new ContactEntity()
               {
                   Id = 1,
                   Name = "Adam",
                   Email = "Adam@adam.pl",
                   Phone = "13424234",
                   OrganizationId = 1,
               },
               new ContactEntity()
               {
                   Id = 2,
                   Name = "Ewa",
                   Email = "Ewa@Ewa.pl",
                   Phone = "02879283",
                   OrganizationId = 2,
               }
           );

            modelBuilder.Entity<OrganizationEntity>()
               .OwnsOne(e => e.Address)
               .HasData(
                   new { OrganizationEntityId = 1, City = "Kraków", Street = "Św. Filipa 17", PostalCode = "31-150", Region = "małopolskie" },
                   new { OrganizationEntityId = 2, City = "Kraków", Street = "Krowoderska 45/6", PostalCode = "31-150", Region = "małopolskie" }
               );
        }
    }
}
