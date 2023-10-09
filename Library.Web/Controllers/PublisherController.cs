using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublishersRepository _publisherRepository;

        public PublisherController(IPublishersRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        public ActionResult Index()
        {
            var publishers = _publisherRepository.GetAllPublishers();
            return View(publishers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _publisherRepository.AddPublisher(publisher);
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var publisher = _publisherRepository.GetPublisherById(id);
            if (publisher == null)
            {
                return HttpNotFound();
            }
            return View(publisher);
        }

        [HttpPost]
        public ActionResult Edit(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _publisherRepository.UpdatePublisher(publisher);
                return RedirectToAction(nameof(Index));
            }
            return View(publisher);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _publisherRepository.DeletePublisher(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
