using System.Collections.Generic;


namespace LibraryManagmentSystem.Models
{
    public interface IAccountsRepository
    {
        AccountsInfo GetUserbyName(string username);
    }
}

