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
        private readonly IAccountsRepository _user;

        public LoginController(ILogger<HomeController> logger, LibraryManagementContext context, IBooksRepository book, IAccountsRepository user)
        {
            _logger = logger;
            _context = context;
            _book = book;
            _user = user;
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
            if(uname != null && psd != null)
            {
                var user  = _user.GetUserbyName(uname);
                

                if (uname.Equals("admin") && psd.Equals("admin"))
                {
                    HttpContext.Session.SetString("username", uname);
                    return RedirectToAction("AllLendRequest", "LendRequest");
                }
                else if (uname.Equals(user.UserName) && psd.Equals(user.Password))
                {
                    HttpContext.Session.SetString("username", uname);
                    return RedirectToAction("AllBooksList", "Books");
                    
                }
                else
                {
                    ViewBag.error = "Invalid Credentials. Check again.";
                    return View("Login");
                }
            }
            else
            {
                ViewBag.error = "Please enter your credentials.";
                return View("Login");
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
