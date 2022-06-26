using System.Collections.Generic;

namespace LibraryManagmentSystem.Models
{
    public interface ILendRequestRepository
    {
        IEnumerable<LendRequest> GetAllLendRequest { get; }
        IEnumerable<LendRequest> GetlendRequestbyId(int Id);
        public LendRequest GetLendRequestByLendId (int LendId);
        IEnumerable<LendRequest> GetAllApprovedBooksList { get; }
        IEnumerable<LendRequest> GetPastRecord { get; }
    }
}
