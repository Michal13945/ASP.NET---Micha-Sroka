using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class FixData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d34c330-5a5f-4689-983d-45dda9ba3ee4", "076b2e35-340c-4e8f-a019-0b978c42cadf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "826a91f2-7521-4ddd-aaff-05daedeab40d", "28e7a36f-f34d-4bfa-8ce5-b465032f3c3d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d34c330-5a5f-4689-983d-45dda9ba3ee4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "826a91f2-7521-4ddd-aaff-05daedeab40d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "076b2e35-340c-4e8f-a019-0b978c42cadf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28e7a36f-f34d-4bfa-8ce5-b465032f3c3d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c87bc95-f6a7-4214-b465-283ade3461b5", "9c87bc95-f6a7-4214-b465-283ade3461b5", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba37abb7-3e30-49bc-9b48-bd70b81b04d9", "ba37abb7-3e30-49bc-9b48-bd70b81b04d9", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e6e1e6d-4350-45c0-9749-16185fe88d44", 0, "024298f7-b381-4a52-abe3-3b52ab0abc75", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER@WSEI.EDU.PL", "AQAAAAEAACcQAAAAEAmYQkrm2RARVIRpa+In6x2bEU5QHct2SsKJwpVabSjnkDTKZd4xmAMRxz/uusvn8w==", null, false, "KH22K26VMALPMHUY4FNJDLAPZNYCCE32", false, "user@wsei.edu.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d1dcfe34-d3d7-4aad-bfcf-e950e069160d", 0, "ea74cb17-6b76-4db9-9352-16e8a3aec765", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN@WSEI.EDU.PL", "AQAAAAEAACcQAAAAEHpbGMsQh4su/LSWHcBGLnS1Rdp22Xsvh4qKGMnCGnzXyf4bPbYaULZPES93QyyvJg==", null, false, "TTV56G4THE2H6K2VTTKXTITTO4R5NE44", false, "admin@wsei.edu.pl" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Adam@adam.pl", "Adam" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Ewa@Ewa.pl", "Ewa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c87bc95-f6a7-4214-b465-283ade3461b5", "2e6e1e6d-4350-45c0-9749-16185fe88d44" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba37abb7-3e30-49bc-9b48-bd70b81b04d9", "d1dcfe34-d3d7-4aad-bfcf-e950e069160d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c87bc95-f6a7-4214-b465-283ade3461b5", "2e6e1e6d-4350-45c0-9749-16185fe88d44" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba37abb7-3e30-49bc-9b48-bd70b81b04d9", "d1dcfe34-d3d7-4aad-bfcf-e950e069160d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c87bc95-f6a7-4214-b465-283ade3461b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba37abb7-3e30-49bc-9b48-bd70b81b04d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e6e1e6d-4350-45c0-9749-16185fe88d44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1dcfe34-d3d7-4aad-bfcf-e950e069160d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d34c330-5a5f-4689-983d-45dda9ba3ee4", "6d34c330-5a5f-4689-983d-45dda9ba3ee4", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "826a91f2-7521-4ddd-aaff-05daedeab40d", "826a91f2-7521-4ddd-aaff-05daedeab40d", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "076b2e35-340c-4e8f-a019-0b978c42cadf", 0, "b005ba53-2fcc-4c8d-a55b-5d94a726e72c", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEL+wfhyNbx4YzmvIFBtTP5+hGlxyGudDToP4RxLY46lfT130yly/lg0Dvy2+pC7Itg==", null, false, "1de84fc4-bf75-49de-a7af-7db25630cf78", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "28e7a36f-f34d-4bfa-8ce5-b465032f3c3d", 0, "e85a048b-de02-4c00-ab7c-a34dd4cb7f0f", "user@wsei.edu.pl", true, false, null, null, "USER", null, null, false, "ce411ac8-250d-4033-b60d-97437a933d3e", false, "user" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Adam", "AA" });

            migrationBuilder.UpdateData(
                table: "contacts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Name" },
                values: new object[] { "Ewa", "C#" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d34c330-5a5f-4689-983d-45dda9ba3ee4", "076b2e35-340c-4e8f-a019-0b978c42cadf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "826a91f2-7521-4ddd-aaff-05daedeab40d", "28e7a36f-f34d-4bfa-8ce5-b465032f3c3d" });
        }
    }
}
