using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagmentSystem.Models
{
    public class BooksRepository : IBooksRepository
    {
        private readonly LibraryManagementContext _libraryManagementContext;
        public BooksRepository(LibraryManagementContext libraryManagementContext)
        {
            _libraryManagementContext = libraryManagementContext;
        }
        public IEnumerable<BooksInfo> GetAllBooks
        {
            get 
            {
                return _libraryManagementContext.Books.Include(a => a.AuthorInfo).Include(p => p.PublisherInfo);      

            }
        }
        public BooksInfo GetBookbyName(string name)
        {
            return _libraryManagementContext.Books.FirstOrDefault(b => b.BookTitle == name);
        }

        public IEnumerable<BooksInfo> GetBooksAvailable
        {
            get
            {
                return _libraryManagementContext.Books.Include(a => a.AuthorInfo).Include(p => p.PublisherInfo).Where(b => b.IsAvailable);
            }
        }
    }
}

