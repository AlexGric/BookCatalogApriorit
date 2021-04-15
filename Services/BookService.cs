using BookCatalogApriorit.Models;
using BookCatalogApriorit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalogApriorit.Services
{
    public class BookService
    {
        private BookRepository _repository { get; set; }

        public BookService(BookRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _repository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _repository.GetBookById(id);
        }

        public void DeleteBook(Book book)
        {
            _repository.DeleteBook(book);
        }

        public void UpdateBook(Book book)
        {
            _repository.Update(book);
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }
    }
}
