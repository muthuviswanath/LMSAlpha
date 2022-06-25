using System.ComponentModel.DataAnnotations;
namespace LibraryManagmentSystem.Models
{
    public class PublisherInfo
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }   
    }
}
