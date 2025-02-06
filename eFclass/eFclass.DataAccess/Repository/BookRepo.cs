using eFclass.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.DataAccess.Repository
{
    public class BookRepo : IBook
    {
        private readonly BookContext _context;

        public BookRepo(BookContext context)
        {
            _context = context;
        }
        public bool AddBook(Book book)
        {
            try {
                var res = _context.Books.Add(book);
                if (res != null)
                {
                    _context.SaveChanges();
                    return true;
                }
            }
                catch (Exception ex) {
                return false;
               
            }
            return false;
        }

        public bool DeleteBook(int bookId)
        {
            try
            {
                var book = _context.Books.FirstOrDefault(x => x.BookId == bookId);
                if (book != null)
                {


                    var res = _context.Books.Remove(book);
                    if (res != null)
                    {
                        _context.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex) {
                return false;
            }
            return false;
        }

        public IEnumerable<Book> GetAllBooks() 
        {
            return _context.Books.Include(x => x.author);
        }

        public Book GetBookDetails(int bookId)
        {
            return _context.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public bool UpdateBook(Book book)
        {
            var bookdet = _context.Books.FirstOrDefault(x => x.BookId == book.BookId);
            bookdet = book;
            _context.SaveChanges();
            return true;
        }
    }
}
