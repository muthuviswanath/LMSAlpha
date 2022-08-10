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
        
    }
}
