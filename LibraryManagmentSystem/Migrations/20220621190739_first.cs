using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagmentSystem.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfCopies = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "LendRequests",
                columns: table => new
                {
                    LendId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LendStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LendRequests", x => x.LendId);
                    table.ForeignKey(
                        name: "FK_LendRequests_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LendRequests_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookTitle", "Category", "ImageURl", "IsAvailable", "NoOfCopies", "Publisher" },
                values: new object[,]
                {
                    { 1, "JK Rowling", "Harry Potter and the Philosopher's Stone", "Fiction", " ", true, 12, "Bloomsbury Publishing" },
                    { 2, "JK Rowling", "Harry Potter and the Chamber of Secrets", "Fiction", " ", true, 16, "Bloomsbury Publishing" },
                    { 3, "JK Rowling", "Harry Potter and the Prisoner of Azkaban", "Fiction", " ", true, 7, "Bloomsbury Publishing" },
                    { 4, "JK Rowling", "Harry Potter and the Goblet of Fire", "Fiction", " ", true, 9, "Bloomsbury Publishing" },
                    { 5, "JK Rowling", "Harry Potter and the Order of the Phoenix", "Fiction", " ", true, 6, "Bloomsbury Publishing" },
                    { 6, "JK Rowling", "Harry Potter and the Half Blood Prince", "Fiction", " ", true, 8, "Bloomsbury Publishing" },
                    { 7, "JK Rowling", "Harry Potter and the Deathly Hallows", "Fiction", " ", true, 8, "Bloomsbury Publishing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LendRequests_BookId",
                table: "LendRequests",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LendRequests_UserId",
                table: "LendRequests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LendRequests");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
