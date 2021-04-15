using BookCatalogApriorit.Models;
using BookCatalogApriorit.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Controllers
{
    public class BookController : Controller
    {
        private BookService _bookService { set; get; }

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            IEnumerable<Book> books =  _bookService.GetBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public  IActionResult Get(int id)
        {
            Book book =  _bookService.GetBookById(id);
            return Ok(book);
        }

        [HttpPost]
        public  IActionResult Create(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }

             _bookService.AddBook(book);

            return Ok();
        }

        public void Delete(Book book)
        {
             _bookService.DeleteBook(book);
        }
        public void Update(Book book)
        {
            _bookService.UpdateBook(book);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
