using Microsoft.AspNetCore.Mvc;
using LibraryManagmentSystem.Models;

namespace LibraryManagmentSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublisherRepository _publisherRepository;
        public BooksController(IBooksRepository booksRepository, IAuthorRepository authorRepository,IPublisherRepository publisherRepository)
        {
            _booksRepository = booksRepository;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult AllBooksList()
        {
            return View(_booksRepository.GetAllBooks);
        }
    }
}
