using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserStartApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bc56eba5-e9fc-44d3-a980-16d0a61bcfbc"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "Phone", "Role", "Status", "UpdatedAt", "Username" },
                values: new object[] { new Guid("bc56eba5-e9fc-44d3-a980-16d0a61bcfbc"), new DateTime(2025, 3, 7, 20, 5, 35, 475, DateTimeKind.Utc).AddTicks(7685), "admin@gmail.com", "Pass@w0rd", "", "Admin", "Active", null, "admin" });
        }
    }
}
