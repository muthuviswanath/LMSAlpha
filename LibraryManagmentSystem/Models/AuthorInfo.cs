using System.ComponentModel.DataAnnotations;
namespace LibraryManagmentSystem.Models
{
    public class AuthorInfo
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
