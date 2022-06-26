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
            modelBuilder.Entity<AccountsInfo>().HasData(
                new AccountsInfo
                {
                    UserId = 2,
                    UserName = "admin",
                    Password = "admin",
                    Role = "Librarian"
                });
            modelBuilder.Entity<AccountsInfo>().HasData(
                new AccountsInfo
                {
                    UserId = 3,
                    UserName = "John",
                    Password = "password",
                    Role = "Student"
                });

            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 1,
                    AuthorName = "JK Rowling"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 2,
                    AuthorName = "Joseph Murphy"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 3,
                    AuthorName = "Dale Carnegie"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId =4 ,
                    AuthorName = "Martin Dunkerton"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 5,
                    AuthorName = "Mark Manson"
                }); 
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 6,
                    AuthorName = "Amit Ghule"
                }); 
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 7,
                    AuthorName = "Arthur Conan Doyle"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 8,
                    AuthorName = "Alice Walker"
                });
            
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 9,
                    AuthorName = "Ralph Ellison"
                }); 
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 10,
                    AuthorName = "J. R. R. Tolkien"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 11,
                    AuthorName = "Rebecca Serle"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 12,
                    AuthorName = "Tana French"
                });
            modelBuilder.Entity<AuthorInfo>().HasData(
                new AuthorInfo
                {
                    AuthorId = 13,
                    AuthorName = "Harper Lee"
                });





            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 1,
                    PublisherName = "Bloomsbury Publishing"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 2,
                    PublisherName = "Simon & Schuster"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 3,
                    PublisherName = "HarperOne"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 4,
                    PublisherName = "Notion Press"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 5,
                    PublisherName = "George Newnes"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 6,
                    PublisherName = "Harcourt Brace Jovanovich"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 7,
                    PublisherName = "Random House"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 8,
                    PublisherName = "Allen & Unwin"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 9,
                    PublisherName = "Simon & Schuster"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 10,
                    PublisherName = "Viking Adult"
                });
            modelBuilder.Entity<PublisherInfo>().HasData(
                new PublisherInfo
                {
                    PublisherId = 11,
                    PublisherName = "J. B. Lippincott & Co."
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
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 8,
                    BookTitle = "The Power of Your Subconscious Mind",
                    NoOfCopies = 15,
                    AuthorId = 2,
                    PublisherId = 2,
                    Category = "Self-Help",
                    ImageURl = "/Images/books/b8.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 9,
                    BookTitle = "How to Win Friends and Influence People",
                    NoOfCopies = 4,
                    AuthorId = 3,
                    PublisherId = 2,
                    Category = "Self-Help",
                    ImageURl = "/Images/books/b9.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 10,
                    BookTitle = "Think and Grow Rich",
                    NoOfCopies = 10,
                    AuthorId = 4,
                    PublisherId = 2,
                    Category = "Self-Help",
                    ImageURl = "/Images/books/b10.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 11,
                    BookTitle = "The Subtle Art of Not Giving a F*ck",
                    NoOfCopies = 5,
                    AuthorId = 5,
                    PublisherId = 3,
                    Category = "Self-Help",
                    ImageURl = "/Images/books/b11.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 12,
                    BookTitle = "Past Forward",
                    NoOfCopies = 12,
                    AuthorId = 6,
                    PublisherId = 4,
                    Category = "Contemporary romance",
                    ImageURl = "/Images/books/b12.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 13,
                    BookTitle = "The Adventures of Sherlock Holmes",
                    NoOfCopies = 23,
                    AuthorId = 7,
                    PublisherId = 5,
                    Category = "Fiction",
                    ImageURl = "/Images/books/b13.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 15,
                    BookTitle = "Invisible Man",
                    NoOfCopies = 34,
                    AuthorId = 9,
                    PublisherId = 7,
                    Category = "Novel",
                    ImageURl = "/Images/books/b15.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 14,
                    BookTitle = "The Color Purple",
                    NoOfCopies = 15,
                    AuthorId = 8,
                    PublisherId = 6,
                    Category = "Epistolary novel",
                    ImageURl = "/Images/books/b14.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 16,
                    BookTitle = "The Lord of the Rings",
                    NoOfCopies = 12,
                    AuthorId = 10,
                    PublisherId = 8,
                    Category = "High fantasy Adventure",
                    ImageURl = "/Images/books/b16.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 17,
                    BookTitle = "One Italian Summer",
                    NoOfCopies = 16,
                    AuthorId = 11,
                    PublisherId = 9,
                    Category = "Domestic Fiction",
                    ImageURl = "/Images/books/b17.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 18,
                    BookTitle = "In the Woods",
                    NoOfCopies = 30,
                    AuthorId = 12,
                    PublisherId = 10,
                    Category = "Mystery",
                    ImageURl = "/Images/books/b18.png",
                    IsAvailable = true
                });
            modelBuilder.Entity<BooksInfo>().HasData(
                new BooksInfo
                {
                    BookId = 19,
                    BookTitle = "To Kill a Mockingbird",
                    NoOfCopies = 19,
                    AuthorId = 13,
                    PublisherId = 11,
                    Category = "Southern Gothic Fiction",
                    ImageURl = "/Images/books/b19.png",
                    IsAvailable = true
                });

        }
        
    }
}
