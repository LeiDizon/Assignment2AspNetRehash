using Microsoft.AspNetCore.Mvc;

namespace Assignment2AspNetRehash.Controllers
{
    public class BorrowingController : Controller
    {
        public IActionResult Borrowing()
        {
            return View();
        }
    }
}
