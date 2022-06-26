using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagmentSystem.Models
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly LibraryManagementContext _libraryManagementContext;

        public AccountsRepository(LibraryManagementContext libraryManagementContext)
        {
            _libraryManagementContext = libraryManagementContext;
        }

        AccountsInfo IAccountsRepository.GetUserbyName(string username)
        {
            return _libraryManagementContext.Accounts.FirstOrDefault(u => u.UserName == username);
        }
    }
}
