using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Repository;

namespace Web.Contoller
{
    public class BookController : Controller
    {
        public readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data=_bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }
    }
}
