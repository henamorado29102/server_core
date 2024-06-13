using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace core.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Lastname", "Name" },
                values: new object[,]
                {
                    { 1, "email1@email.com", "Lastname 1", "User 1" },
                    { 2, "email1@email.com", "Lastname 2", "User 2" },
                    { 3, "email1@email.com", "Lastname 3", "User 3" },
                    { 4, "email1@email.com", "Lastname 4", "User 4" },
                    { 5, "email1@email.com", "Lastname 5", "User 5" },
                    { 6, "email1@email.com", "Lastname 6", "User 6" },
                    { 7, "email1@email.com", "Lastname 7", "User 7" },
                    { 8, "email1@email.com", "Lastname 8", "User 8" },
                    { 9, "email1@email.com", "Lastname 9", "User 9" },
                    { 10, "email1@email.com", "Lastname 10", "User 10" },
                    { 11, "email1@email.com", "Lastname 11", "User 11" },
                    { 12, "email1@email.com", "Lastname 12", "User 12" },
                    { 13, "email1@email.com", "Lastname 13", "User 13" },
                    { 14, "email1@email.com", "Lastname 14", "User 14" },
                    { 15, "email1@email.com", "Lastname 15", "User 15" },
                    { 16, "email1@email.com", "Lastname 16", "User 16" },
                    { 17, "email1@email.com", "Lastname 17", "User 17" },
                    { 18, "email1@email.com", "Lastname 18", "User 18" },
                    { 19, "email1@email.com", "Lastname 19", "User 19" },
                    { 20, "email1@email.com", "Lastname 20", "User 20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
