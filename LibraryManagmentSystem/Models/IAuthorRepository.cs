using System.Collections.Generic;

namespace LibraryManagmentSystem.Models
{
    public interface IAuthorRepository
    {
        IEnumerable<AuthorInfo> GetAllAuthors { get; }
    }
}
