using Microsoft.AspNetCore.Mvc;
using LibraryManagmentSystem.Models;
using System.Linq;

namespace LibraryManagmentSystem.Controllers
{
    public class LendRequestController : Controller
    {
        private readonly ILendRequestRepository _lendRequestRepository;
        private readonly IBooksRepository _booksRepository; 
        private readonly LibraryManagementContext _libraryManagementContext;

        public LendRequestController(ILendRequestRepository lendRequestRepository, LibraryManagementContext libraryManagementContext, IBooksRepository booksRepository)
        {
            _lendRequestRepository = lendRequestRepository;
            _libraryManagementContext = libraryManagementContext;
            _booksRepository = booksRepository;
        }


        public IActionResult AllLendRequest()
        {
            return View(_lendRequestRepository.GetAllLendRequest);
        }
       
        public IActionResult LendRequestById(int Userid)
        {

            var request = _lendRequestRepository.GetlendRequestbyId(Userid);
            if(request == null)
            {
                return NotFound();
            }
            return View(request);
        }
        public ViewResult RequestToLend(int bookId)
        {
            int userId = 1;
            LendRequest lendRequest = new LendRequest
            {
                LendStatus = "Requested",
                UserId = userId,
                BookId = bookId,
                LendDate = System.DateTime.MinValue,
                AccountsInfo = _libraryManagementContext.Accounts.SingleOrDefault(u => u.UserId == userId),
                BooksInfo = _libraryManagementContext.Books.SingleOrDefault(b=>b.BookId == bookId)
            }; 

            _libraryManagementContext.LendRequests.Add(lendRequest);
            _libraryManagementContext.SaveChanges();
            return View();
        }
        public RedirectToActionResult Approval(int lendId) 
        {
            LendRequest lendRequest = _lendRequestRepository.GetLendRequestByLendId(lendId);
            lendRequest.LendStatus = "Approved";
            lendRequest.LendDate = System.DateTime.Now;
            lendRequest.ReturnDate = System.DateTime.Now;
            lendRequest.ReturnDate.AddDays(15);
            _libraryManagementContext.SaveChanges();
            return RedirectToAction("AllLendRequest");
        }
        public RedirectToActionResult Decline(int lendId)
        {
            LendRequest lendRequest = _lendRequestRepository.GetLendRequestByLendId(lendId);
            lendRequest.LendStatus = "Declined";
            lendRequest.LendDate = System.DateTime.Now;
            lendRequest.ReturnDate = System.DateTime.Now;
            _libraryManagementContext.SaveChanges();
            return RedirectToAction("AllLendRequest");
        }
    }
}
