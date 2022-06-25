
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
        public DateTime ReturnDate { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public AccountsInfo AccountsInfo { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public BooksInfo BooksInfo { get; set; }
        public double? FineAmount { get; set; }

    }
}

