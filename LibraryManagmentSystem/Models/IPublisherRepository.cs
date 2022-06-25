using System.Collections.Generic;

namespace LibraryManagmentSystem.Models
{
    public interface IPublisherRepository
    {
        IEnumerable<PublisherInfo> GetAllPublishers { get; }
    }
}
