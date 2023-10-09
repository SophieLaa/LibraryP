using Library.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using Publisher = Library.Web.Publisher;

namespace Library.Data.Repositories
{
    public class PublishersRepository : RepositoryBase<Publisher>, IPublishersRepository
    {
        public PublishersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Publisher GetPublishersByFirstName(string Name)
        {
            var Publisher = this.DbContext.Publishers.Where(c => c.Name == Name).FirstOrDefault();

            return Publisher;
        }
        public Publisher GetPublishersByEmail(string Email)
        {
            var Publisher = this.DbContext.Publishers.Where(c => c.Email == Email).FirstOrDefault();

            return Publisher;
        }
        public Publisher GetMembersByPhoneNumber(string PhoneNumber)
        {
            var Publisher = this.DbContext.Publishers.Where(c => c.PhoneNumber == PhoneNumber).FirstOrDefault();

            return Publisher;
        }


        public override void Update(Publisher entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
        public List<Publisher> GetAllPublishers()
    {
        return DbContext.Publishers.ToList();
    }

    public void AddPublisher(Publisher publisher)
    {
        DbContext.Publishers.Add(publisher);
    }

    public Publisher GetPublisherById(int id)
    {
        return DbContext.Publishers.FirstOrDefault(p => p.ID == id);
    }

    public void UpdatePublisher(Publisher publisher)
    {
       
        publisher.ChangeDate = DateTime.Now;
        base.Update(publisher);
    }

    public void DeletePublisher(int id)
    {
        var publisher = this.DbContext.Publishers.FirstOrDefault(p => p.ID == id);
        if (publisher != null)
        {
            DbContext.Publishers.Remove(publisher);
        }
    }
    }

    public interface IPublishersRepository : IRepository<Publisher>
    {
        Publisher GetPublishersByFirstName(string FirstName);
        Publisher GetPublishersByEmail(string Email);
        Publisher GetMembersByPhoneNumber(string PhoneNumber);
        List<Publisher> GetAllPublishers();
        void AddPublisher(Publisher publisher);
        Publisher GetPublisherById(int id);
        void UpdatePublisher(Publisher publisher);
        void DeletePublisher(int id);

    }
}
