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
                return _libraryManagementContext.LendRequests.Include(b=>b.BooksInfo);
            }
        }
        public IEnumerable<LendRequest> GetlendRequestbyId(int Id)
        {
            return _libraryManagementContext.LendRequests.Where(u => u.UserId == Id);
        }
    }
}
