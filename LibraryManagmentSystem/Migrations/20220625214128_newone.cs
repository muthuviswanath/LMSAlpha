using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagmentSystem.Migrations
{
    public partial class newone : Migration
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
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfCopies = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuedBooks = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LendRequests",
                columns: table => new
                {
                    LendId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LendStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    FineAmount = table.Column<double>(type: "float", nullable: true)
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
                table: "Accounts",
                columns: new[] { "UserId", "Password", "Role", "UserName" },
                values: new object[] { 1, "alpha", "Student", "Team Alpha" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 13, "Harper Lee" },
                    { 11, "Rebecca Serle" },
                    { 10, "J. R. R. Tolkien" },
                    { 9, "Ralph Ellison" },
                    { 8, "Alice Walker" },
                    { 7, "Sir Arthur Conan Doyle" },
                    { 12, "Tana French" },
                    { 5, "Mark Manson" },
                    { 4, "Martin Dunkerton" },
                    { 3, "Dale Carnegie" },
                    { 2, "Joseph Murphy" },
                    { 1, "JK Rowling" },
                    { 6, "Amit Ghule" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "PublisherName" },
                values: new object[,]
                {
                    { 9, "Simon & Schuster" },
                    { 8, "Allen & Unwin" },
                    { 7, "Random House" },
                    { 6, "Harcourt Brace Jovanovich" },
                    { 3, "HarperOne" },
                    { 4, "Notion Press" },
                    { 2, "Simon & Schuster" },
                    { 1, "Bloomsbury Publishing" },
                    { 10, "Viking Adult" },
                    { 5, "George Newnes" },
                    { 11, "J. B. Lippincott & Co." }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BookTitle", "Category", "ImageURl", "IsAvailable", "IssuedBooks", "NoOfCopies", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1, "Harry Potter and the Philosopher's Stone", "Fiction", "/Images/books/b1.png", true, 0, 12, 1 },
                    { 17, 11, "One Italian Summer", "Contemporary romance, Domestic Fiction", "/Images/books/b17.png", true, 0, 16, 9 },
                    { 16, 10, "The Lord of the Rings", "High fantasy Adventure", "/Images/books/b16.png", true, 0, 12, 8 },
                    { 15, 9, "Invisible Man", "Novel", "/Images/books/b15.png", true, 0, 34, 7 },
                    { 14, 8, "The Color Purple", "Epistolary novel", "/Images/books/b14.png", true, 0, 15, 6 },
                    { 13, 7, "The Adventures of Sherlock Holmes", "Fiction", "/Images/books/b13.png", true, 0, 23, 5 },
                    { 12, 6, "Past Forward", "Contemporary romance", "/Images/books/b12.png", true, 0, 12, 4 },
                    { 11, 5, "The Subtle Art of Not Giving a F**k", "Self-Help", "/Images/books/b11.png", true, 0, 5, 3 },
                    { 18, 12, "In the Woods", "Mystery", "/Images/books/b.png", true, 0, 30, 10 },
                    { 10, 4, "Think and Grow Rich", "Self-Help", "/Images/books/b10.png", true, 0, 10, 2 },
                    { 8, 2, "The Power of Your Subconscious Mind", "Self-Help", "/Images/books/b8.png", true, 0, 15, 2 },
                    { 7, 1, "Harry Potter and the Deathly Hallows", "Fiction", "/Images/books/b7.png", true, 0, 8, 1 },
                    { 6, 1, "Harry Potter and the Half Blood Prince", "Fiction", "/Images/books/b6.png", true, 0, 8, 1 },
                    { 5, 1, "Harry Potter and the Order of the Phoenix", "Fiction", "/Images/books/b5.png", true, 0, 6, 1 },
                    { 4, 1, "Harry Potter and the Goblet of Fire", "Fiction", "/Images/books/b4.png", true, 0, 9, 1 },
                    { 3, 1, "Harry Potter and the Prisoner of Azkaban", "Fiction", "/Images/books/b3.png", true, 0, 7, 1 },
                    { 2, 1, "Harry Potter and the Chamber of Secrets", "Fiction", "/Images/books/b2.png", true, 0, 16, 1 },
                    { 9, 3, "How to Win Friends and Influence People", "Self-Help", "/Images/books/b9.png", true, 0, 4, 2 },
                    { 19, 13, "To Kill a Mockingbird", "Southern Gothic Fiction", "/Images/books/b19.png", true, 0, 19, 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

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

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
