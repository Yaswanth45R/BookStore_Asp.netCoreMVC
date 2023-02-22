using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Respository;

namespace Webgentle.BookStore.Contollers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository(); 
        }
        public ViewResult GetAllBooks()
        {
            return View();
        }
        public BookModel GetBook(int id) 
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
