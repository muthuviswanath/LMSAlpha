using System.Collections.Generic;

namespace LibraryManagmentSystem.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryManagementContext _libraryManagementContext;

        public AuthorRepository(LibraryManagementContext libraryManagementContext)
        {
            _libraryManagementContext = libraryManagementContext;
        }
        public IEnumerable<AuthorInfo> GetAllAuthors=> _libraryManagementContext.Authors;
    }
}
