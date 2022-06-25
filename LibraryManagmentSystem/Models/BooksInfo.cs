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
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public AuthorInfo AuthorInfo { get; set; }
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public PublisherInfo PublisherInfo { get; set; }
        public string Category { get; set; }
        public string ImageURl { get; set; }
        public int IssuedBooks { get; set; } = 0;
        public bool IsAvailable { get; set; } 
        
        public BooksInfo()
        {
            if (NoOfCopies - IssuedBooks > 0)
                IsAvailable = true;
            else
                IsAvailable = false;
        }
        

    }
}
