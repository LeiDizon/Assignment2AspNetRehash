using Assignment2AspNetRehash.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2AspNetRehash.Controllers
{
    [Route("Reader")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        [HttpPost("{readerId}")]
        public IActionResult PosteReader(int id)
        {
            return Ok($"Reader with ID: {id} added successfully");
        }

        [HttpGet("{readerId}")]
        public IActionResult GetReaderById(int id)
        {
            return Ok($"Details of reader with ID: {id}");
        }
    }
}
