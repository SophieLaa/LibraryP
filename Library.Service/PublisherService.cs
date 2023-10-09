using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Repositories;
using Library.Web;

namespace Library.Service
{
    public class PublisherService : IPublisherService
    {
        private readonly IPublishersRepository _publisherRepository;

        public PublisherService(IPublishersRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public void AddPublisher(PublisherViewModel publisherViewModel)
        {
            var publisher = new Publisher
            {
                Name = publisherViewModel.PublisherName,

            };

            _publisherRepository.Add(publisher);
            _publisherRepository.Save();
        }
    }
}
