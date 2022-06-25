using System.Collections.Generic;
namespace LibraryManagmentSystem.Models
{
    public interface IBooksRepository
    {
        IEnumerable<BooksInfo> GetAllBooks { get; }
        IEnumerable<BooksInfo> GetBooksAvailable { get; } 
        BooksInfo GetBookbyName(string name);
    }
}
