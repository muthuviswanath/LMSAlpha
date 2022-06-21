using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
namespace LibraryManagmentSystem.Models
{
    public class BooksInfo
    {
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public int NoOfCopies { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string ImageURl { get; set; }
        public bool IsAvailable { get; set; }

    }
}
