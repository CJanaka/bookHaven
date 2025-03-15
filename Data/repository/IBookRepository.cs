using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(int bookId);
        Book GetById(int bookId);
        List<Book> GetAll();
        List<Book> SearchBooks(string keyword);
    }
}
