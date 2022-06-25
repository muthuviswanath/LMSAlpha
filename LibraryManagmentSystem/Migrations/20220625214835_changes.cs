using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagmentSystem.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "AuthorName",
                value: "Arthur Conan Doyle");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "BookTitle",
                value: "The Subtle Art of Not Giving a F*ck");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                column: "Category",
                value: "Domestic Fiction");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                column: "ImageURl",
                value: "/Images/books/b18.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "AuthorName",
                value: "Sir Arthur Conan Doyle");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11,
                column: "BookTitle",
                value: "The Subtle Art of Not Giving a F**k");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17,
                column: "Category",
                value: "Contemporary romance, Domestic Fiction");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18,
                column: "ImageURl",
                value: "/Images/books/b.png");
        }
    }
}
