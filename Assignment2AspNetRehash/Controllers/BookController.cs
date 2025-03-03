using Assignment2AspNetRehash.Models;
using Microsoft.AspNetCore.Mvc;
//This page handles request flow. Does not handle data logic
namespace Assignment2AspNetRehash.Controllers
{
    [Route("Books")]
    public class BookController : Controller
    {
        //[Route("/Books")]//Do ? then the variable name to set the variable values ex. /Books?bookid=book value&author=author value

        //public IActionResult Book(int? bookid, string? author)//Setting the params here so this: int? bookid = Convert.ToInt32(Request.Query["BookId"]); and this: string? author = Convert.ToString(Request.RouteValues["Author"]); will not be necessary
        //{
        //    //int? bookid = Convert.ToInt32(Request.Query["BookId"]);
        //    //string? author = Convert.ToString(Request.RouteValues["Author"]);
        //    return Content($"Book Id is: {bookid}\nAuthor is: {author}", "text/plain");

        //    //return View();
        //}
        //public IActionResult Book(([FromQuery]--> Data Annotation) Book book) 

        [HttpPost("{bookId?}/{author?}")]
        public IActionResult Book(int? bookId, string? author)
        {
            if (!bookId.HasValue)
            {
                return Content("Book ID not found", "text/plain");
            }

            return Content($"Book Id is: {bookId}\nAuthor is: {author}", "text/plain");
        }


        [HttpGet("{bookId?}/{bookTitle?}/{author?}/{category?}")]
        public IActionResult Book(int? bookId, string? bookTitle, string? author, string? category)
        {

            return Content($"Book ID is: {bookId}\nTitle is: {bookTitle}\nAuthor is: {author}\nCategory is: {category}", "text/plain");
        }


        [HttpDelete("{bookId?}/{bookTitle?}/{author?}/{isbn?}")]
        public IActionResult DeleteBook(int? bookId, string? bookTitle, string? author, string? isbn)
        {
            return Content($"Book ID is: {bookId}\nTitle is: {bookTitle}\nAuthor is: {author}\nISBN is: {isbn}", "text/plain");
        }


        [HttpGet("{bookId?}/{bookTitle?}/{author?}/{isbn?}/{category?}")]
        public IActionResult Book(int? bookId, string? bookTitle, string? author, string? isbn, string? category)
        {


            return Content($"Book ID is: {bookId}\nTitle is: {bookTitle}\nAuthor is: {author}\nISBN is: {isbn}\nCategory is: {category}", "text/plain");
        }
    }
}
