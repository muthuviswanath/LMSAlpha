using System.Collections.Generic;

namespace LibraryManagmentSystem.Models
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly LibraryManagementContext _libraryManagementContext;

        public PublisherRepository(LibraryManagementContext libraryManagementContext)
        {
            _libraryManagementContext = libraryManagementContext;
        }
        public IEnumerable<PublisherInfo> GetAllPublishers => _libraryManagementContext.Publishers;
    }
}
   