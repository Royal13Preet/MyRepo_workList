using AutoMapper;
using eFclass.DataAccess.Repository;
using eFclass.Models.DBModels;
using eFclass.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFclass.Managers
{
    public class BookManager : IBookManager
    {
        private readonly IBook _bookRepo;
        private readonly IMapper _mapper;

        public BookManager(IBook bookManager, IMapper mapper)
        {
            _bookRepo = bookManager;
            _mapper = mapper;
        }

    /// <see cref="IBookManager.AddNewBook(BookDto)"/>
        public bool AddNewBook(BookDto book)
        {
            Book dbBook = _mapper.Map<Book>(book);
            return _bookRepo.AddBook(dbBook);
        }

        /// <see cref="IBookManger.GetAllBooks()"/>
        public IEnumerable<BookDto> GetAllBooks()
        {
            var books = _bookRepo.GetAllBooks();
            return _mapper.Map<List<BookDto>>(books);   
            
        }

        public BookDto GetBooksDetails(int bookId)
        {
            var book = _bookRepo.GetBookDetails(bookId);
            return _mapper.Map<BookDto>(book);
        }

        public bool RemoveNewBook(int bookId)
        {

            return _bookRepo.DeleteBook(bookId);
        }

        public bool UpdateBook(BookDto book)
        {
            var dbBok = _mapper.Map<Book>(book);
            return _bookRepo.UpdateBook(dbBok);

        }
    }
}
