using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution1.Core.Models;
using Solution1.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
    }
}
