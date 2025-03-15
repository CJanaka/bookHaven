using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book) => _bookRepository.Add(book);
        public void UpdateBook(Book book) => _bookRepository.Update(book);
        public void DeleteBook(int bookId) => _bookRepository.Delete(bookId);
        public Book GetBookById(int bookId) => _bookRepository.GetById(bookId);
        public List<Book> GetAllBooks() => _bookRepository.GetAll();
        public List<Book> SearchBooks(string keyword) => _bookRepository.SearchBooks(keyword);

    }
}
