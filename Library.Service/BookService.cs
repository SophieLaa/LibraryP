using Library.Data.Infrastructure;
using Library.Data.Repositories;
using Library.Web;
using System.Collections.Generic;

namespace Library.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void CreateBook(Book book);
        void SaveBook();
    }

    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly IUnitOfWork unitOfWork;

        public BookService(IBookRepository bookRepository, IUnitOfWork unitOfWork)
        {
            this.bookRepository = bookRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookRepository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return bookRepository.GetById(id);
        }

        public void CreateBook(Book book)
        {
            bookRepository.Add(book);
        }

        public void SaveBook()
        {
            unitOfWork.Commit();
        }
    }
}
