using Solution1.Core.Models;
using Solution1.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution1.ServiceLibrary
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
