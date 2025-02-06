using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Services
{
    public interface IBookService
    {
        bool AddNewBook(BookDto book);
        IEnumerable<BookDto> GetAllBooks();
        bool RemoveBook(int bookId);
        bool UpdateBook(BookDto book);

        public interface IBookManager
        {
            /// <summary>
            /// Add new Books
            /// </summary>
            /// <param name="book"></param>
            /// <returns></returns>
            public bool AddNewBook(BookDto book);
            /// <summary>
            /// Remove books based on Id
            /// </summary>
            /// <param name="bookId"></param>
            /// <returns></returns>
            public bool RemoveNewBook(int bookId);

            /// <summary>
            /// Get book details 
            /// </summary>
            /// <returns></returns>
            public IEnumerable<BookDto> GetAllBooks();

            /// <summary>
            /// Get book details by Id
            /// </summary>
            /// <param name="bookId"></param>
            /// <returns></returns>
            public BookDto GetBooksDetails(int bookId);

            /// <summary>
            /// Update a book
            /// </summary>
            /// <param name="book"></param>
            /// <returns></returns>
            public bool UpdateBook(BookDto book);
        }
    }
}
