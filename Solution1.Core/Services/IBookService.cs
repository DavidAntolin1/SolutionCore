using Solution1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1.Core.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
    }
}
