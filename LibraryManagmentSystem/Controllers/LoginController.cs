using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibraryManagmentSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystem.Controllers
{

    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryManagementContext _context;
        private readonly IBooksRepository _book;

        public LoginController(ILogger<HomeController> logger, LibraryManagementContext context, IBooksRepository book)
        {
            _logger = logger;
            _context = context;
            _book = book;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AdminView()
        {
            return View("AdminView");
        }


        [HttpPost]
        public IActionResult Login(string uname, string psd)
        {
            if (uname != null && psd != null && uname.Equals("admin") && psd.Equals("admin"))
            {
                HttpContext.Session.SetString("username", uname);
                return RedirectToAction("AllLendRequest", "LendRequest");
            }
            else if (uname != null && psd != null && uname.Equals("John") && psd.Equals("password"))
            {
                HttpContext.Session.SetString("username", uname);
                return RedirectToAction("AllBooksList", "Books");
                //return View("Search");
            }
            else
            {
                ViewBag.error = "Invalid Credentials. Check again.";
                return View("Index");
            }
        }

        public async Task<IActionResult> Index(string SearchString)
        {
            var books = from b in _context.Accounts
                        select b;

            if (!String.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.UserName.Contains(SearchString));
            }

            return View(await books.ToListAsync());
        }


    }




}