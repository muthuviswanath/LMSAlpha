using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace LibraryManagmentSystem.Models
{
    public class LendRequest
    {
        [Key]
        public int LendId { get; set; }
        public string LendStatus { get; set; }
        public DateTime LendDate { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("UserName")]
        public string UserName { get; set; }    
        
        public AccountsInfo AccountsInfo { get; set; }

        [ForeignKey("BookId")]
        public int BookId { get; set; }

        [ForeignKey("BookTitle")]
        public string BookTitle { get; set; }
        
        public BooksInfo BooksInfo { get; set; }

    }
}
