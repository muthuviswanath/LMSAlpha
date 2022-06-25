using Microsoft.AspNetCore.Mvc;
using LibraryManagmentSystem.Models;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace LibraryManagmentSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly LibraryManagementContext _context;
        public BooksController(IBooksRepository booksRepository, IAuthorRepository authorRepository,IPublisherRepository publisherRepository, LibraryManagementContext context)
        {
            _booksRepository = booksRepository;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
            _context = context;
        }
        public IActionResult AllBooksList()
        {
            return View(_booksRepository.GetAllBooks);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { IsBookAvailable = false });
        }
        public async Task<IActionResult> Search(string SearchString)
        {
            var books = from b in _context.Books
                        select b;
            

            if (!String.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.BookTitle.Contains(SearchString) || s.AuthorInfo.AuthorName.Contains(SearchString) || s.Category.Contains(SearchString));
                
            }

            return View(await books.ToListAsync());
        }
    }
}
