using System.Collections.Generic;
using Library.Model;
using Library.Web;

namespace Library.Data.Repositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        List<Book> GetAll();
        Book GetById(int id);
    }
}
