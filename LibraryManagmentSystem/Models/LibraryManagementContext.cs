using Microsoft.EntityFrameworkCore;
namespace LibraryManagmentSystem.Models
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options) : base(options) { }

        public DbSet<BooksInfo> Books { get; set; }
        public DbSet<AccountsInfo> Accounts { get; set; }
        public DbSet<LendRequest> LendRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 1,
                    BookTitle = "Harry Potter and the Philosopher's Stone",
                    NoOfCopies = 12,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 2,
                    BookTitle = "Harry Potter and the Chamber of Secrets",
                    NoOfCopies = 16,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 3,
                    BookTitle = "Harry Potter and the Prisoner of Azkaban",
                    NoOfCopies = 7,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 4,
                    BookTitle = "Harry Potter and the Goblet of Fire",
                    NoOfCopies = 9,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 5,
                    BookTitle = "Harry Potter and the Order of the Phoenix",
                    NoOfCopies = 6,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 6,
                    BookTitle = "Harry Potter and the Half Blood Prince",
                    NoOfCopies = 8,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 7,
                    BookTitle = "Harry Potter and the Deathly Hallows",
                    NoOfCopies = 8,
                    Author = "JK Rowling",
                    Publisher = "Bloomsbury Publishing",
                    Category = "Fiction",
                    ImageURl = " ",
                    IsAvailable = true
                });
           
        }
        
    }
}
