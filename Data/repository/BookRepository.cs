using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public void Delete(int bookId)
        {
            var book = _context.Books.Find(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public Book GetById(int bookId) => _context.Books.Find(bookId);

        public List<Book> GetAll() => _context.Books.ToList();

        public List<Book> SearchBooks(string keyword)
        {
            return _context.Books
                .Where(b => b.Title.Contains(keyword) || b.Author.Contains(keyword) || b.Genre.Contains(keyword) || b.Isbn.Contains(keyword))
                .ToList();
        }
    }
}
