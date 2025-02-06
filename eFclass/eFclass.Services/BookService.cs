using eFclass.Managers;
using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Services
{
    public class BookService : IBookService
    {
        private readonly IBookManager _bookService;
        public BookService(IBookManager bookService)
        {
            _bookService = bookService;
            
        }

        bool IBookService.AddNewBook(BookDto book)
        {
            
            return _bookService.AddNewBook(book);
        }

        
         IEnumerable<BookDto> IBookService.GetAllBooks()
        {
           
            return _bookService.GetAllBooks();

        }

        BookDto GetBooksDetails(int bookId)
        {
            return _bookService.GetBooksDetails(bookId);
            
        }

        bool IBookService.RemoveBook(int bookId)
        {

            return _bookService.RemoveNewBook(bookId);
        }
         bool IBookService.UpdateBook(BookDto book)
        {
            
            return _bookService.UpdateBook(book);

        }

    }
}
