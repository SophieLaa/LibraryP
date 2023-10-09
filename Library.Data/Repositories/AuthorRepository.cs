using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Author GetAuthorByName(string AuthorName)
        {
            var Author = this.DbContext.Authors.Where(c => c.FirstName == AuthorName).FirstOrDefault();

            return Author;
        }
        public Author GetAuthorByLastName(string AuthorLastName)
        {
            var Author = this.DbContext.Authors.Where(c => c.LastName == AuthorLastName).FirstOrDefault();

            return Author;
        }

        public override void Update(Author entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorByName(string AuthorName);
        Author GetAuthorByLastName(string AuthorLastName);
    }
}
