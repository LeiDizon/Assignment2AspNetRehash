using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment2AspNetRehash.Models
{
    public class Borrowing
    {
        public int? LoanId { get; set; }
        public int? BookId { get; set; }
        public int? ReaderId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? OverdueCharges { get; set; }
    }
}
