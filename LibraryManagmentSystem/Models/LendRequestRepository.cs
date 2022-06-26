using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace LibraryManagmentSystem.Models
{
    public class LendRequestRepository : ILendRequestRepository
    {
        private readonly LibraryManagementContext _libraryManagementContext;

        public LendRequestRepository(LibraryManagementContext libraryManagementContext)
        {
            _libraryManagementContext = libraryManagementContext;
        }

        public IEnumerable<LendRequest> GetAllLendRequest
        {
            get
            {
                return _libraryManagementContext.LendRequests.Include(b=>b.BooksInfo).Include(u=>u.AccountsInfo).Where(l=>l.LendStatus == "Requested");
            }
        }
        public IEnumerable<LendRequest> GetlendRequestbyId(int Id)
        {
            return _libraryManagementContext.LendRequests.Include(b => b.BooksInfo).Include(u => u.AccountsInfo).Where(u => u.UserId == Id);
        }
        public LendRequest GetLendRequestByLendId(int LendId)
        {
            return _libraryManagementContext.LendRequests.Include(b => b.BooksInfo).Include(u => u.AccountsInfo).FirstOrDefault(l=> l.LendId == LendId);
        }
        public IEnumerable<LendRequest> GetAllApprovedBooksList
        {
            get
            {
                return _libraryManagementContext.LendRequests.Include(b => b.BooksInfo).Include(u => u.AccountsInfo).Where(l => l.LendStatus == "Approved");
            }
        }
        public IEnumerable<LendRequest> GetPastRecord
        {
            get
            {
                return _libraryManagementContext.LendRequests.Include(b => b.BooksInfo).Include(u => u.AccountsInfo).Where(l => l.LendStatus == "Returned" || l.LendStatus == "Declined");
            }
        }
    }
}
