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

        public BooksInfo GetBookById(int BookId)
        {
            return _libraryManagementContext.Books.FirstOrDefault(b=>b.BookId == BookId);
        }

       

IEnumerable<BooksInfo> IBooksRepository.GetBooksAvailable => throw new NotImplementedException();
    }
}

