using Microsoft.EntityFrameworkCore;
namespace LibraryManagmentSystem.Models
{
    public class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options) : base(options) { }

        public DbSet<BooksInfo> Books { get; set; }
        public DbSet<AccountsInfo> Accounts { get; set; }
        public DbSet<LendRequest> LendRequests { get; set; }
        public DbSet<AuthorInfo> Authors { get; set; }
        public DbSet<PublisherInfo> Publishers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountsInfo>().HasData(
                new AccountsInfo
                {
                    UserId=1,
                    UserName="Team Alpha",
                    Password="alpha",
                    Role ="Student"
                });

            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 1,
                    AuthorName = "JK Rowling"
                });

            
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 1,
                    PublisherName = "Bloomsbury Publishing"
                });


            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 1,
                    BookTitle = "Harry Potter and the Philosopher's Stone",
                    NoOfCopies = 12,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b1.png",
                    IsAvailable = true
                
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 2,
                    BookTitle = "Harry Potter and the Chamber of Secrets",
                    NoOfCopies = 16,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b2.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 3,
                    BookTitle = "Harry Potter and the Prisoner of Azkaban",
                    NoOfCopies = 7,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b3.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 4,
                    BookTitle = "Harry Potter and the Goblet of Fire",
                    NoOfCopies = 9,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b4.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 5,
                    BookTitle = "Harry Potter and the Order of the Phoenix",
                    NoOfCopies = 6,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b5.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 6,
                    BookTitle = "Harry Potter and the Half Blood Prince",
                    NoOfCopies = 8,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b6.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 7,
                    BookTitle = "Harry Potter and the Deathly Hallows",
                    NoOfCopies = 8,
                    AuthorId = 1,
                    PublisherId = 1,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b7.png",
                    IsAvailable = true
                });
        }
        
    }
}
