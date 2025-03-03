using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment2AspNetRehash.Models
{


public class Book
    {
        public int? BookId { get; set; }
        public string? BookTitle { get; set; }
        public string? Author { get; set; }
        public string? Isbn { get; set; }
        public string? Category { get; set; }

    }
}

