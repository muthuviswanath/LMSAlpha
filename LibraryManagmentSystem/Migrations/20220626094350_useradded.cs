using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagmentSystem.Migrations
{
    public partial class useradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "UserId", "Password", "Role", "UserName" },
                values: new object[] { 2, "admin", "Librarian", "admin" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "UserId", "Password", "Role", "UserName" },
                values: new object[] { 3, "password", "Student", "John" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "UserId",
                keyValue: 3);
        }
    }
}
