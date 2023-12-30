using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63f39718-32c1-4b13-9251-f7b71f6ba853", "4d83c29f-b610-4d99-b02f-3e6d5bb385d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f78f9c29-9261-4d4a-8d3f-3120c352d8f0", "b2c17b31-d674-4cd4-a5cb-7bb147665a55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63f39718-32c1-4b13-9251-f7b71f6ba853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f78f9c29-9261-4d4a-8d3f-3120c352d8f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d83c29f-b610-4d99-b02f-3e6d5bb385d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2c17b31-d674-4cd4-a5cb-7bb147665a55");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d34c330-5a5f-4689-983d-45dda9ba3ee4", "076b2e35-340c-4e8f-a019-0b978c42cadf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "826a91f2-7521-4ddd-aaff-05daedeab40d", "28e7a36f-f34d-4bfa-8ce5-b465032f3c3d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "63f39718-32c1-4b13-9251-f7b71f6ba853", "63f39718-32c1-4b13-9251-f7b71f6ba853", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f78f9c29-9261-4d4a-8d3f-3120c352d8f0", "f78f9c29-9261-4d4a-8d3f-3120c352d8f0", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4d83c29f-b610-4d99-b02f-3e6d5bb385d4", 0, "53e110a0-01f5-40bb-bdb0-ccc9e926cd13", "admin@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEKyeSh5gXrMM6XOL5tU5jP95/xqPHaKPr6CHS7in4T0iSeyVGy/n31+iHqfyVEJ+Qw==", null, false, "2b83cab7-dce5-47cb-852e-56e3636f3bfc", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b2c17b31-d674-4cd4-a5cb-7bb147665a55", 0, "fb3f497e-3c7c-4f4f-9ff9-4d747b6c645a", "user@wsei.edu.pl", true, false, null, null, "USER", null, null, false, "d9da53bf-ca62-48ee-bff7-25187c149ae1", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63f39718-32c1-4b13-9251-f7b71f6ba853", "4d83c29f-b610-4d99-b02f-3e6d5bb385d4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f78f9c29-9261-4d4a-8d3f-3120c352d8f0", "b2c17b31-d674-4cd4-a5cb-7bb147665a55" });
        }
    }
}
