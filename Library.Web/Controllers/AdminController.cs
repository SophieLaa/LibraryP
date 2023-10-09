using Library.Service;
using Library.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookService bookService;

        private readonly IPublisherService _publisherService;
        private readonly IPositionService _positionService;

        public AdminController(IPublisherService publisherService, IPositionService positionService)
        {
            _publisherService = publisherService;
            _positionService = positionService;
        }

        [HttpPost]
        public ActionResult AddPublisher(PublisherViewModel publisherViewModel)
        {
            _publisherService.AddPublisher(publisherViewModel);
            return RedirectToAction("Index", "Home"); // Redirect to the appropriate page after adding publisher
        }

        [HttpPost]
        public ActionResult AddPosition(PositionViewModel positionViewModel)
        {
            _positionService.AddPosition(positionViewModel);
            return RedirectToAction("Index", "Home"); // Redirect to the appropriate page after adding position
        }
        public AdminController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public ActionResult ListBooks()
        {
            
            IEnumerable<BookViewModel> books = bookService.GetAllBooks()
                .Select(b => new BookViewModel
                {
                    ID = b.ID,
                    Title = b.Title,
                    PublicationDate = b.PublicationDate,
                    Edition = b.Edition,
                    PageNumber = b.PageNumber,
                    TotalCopies = b.TotalCopies,
                    AvailableCopies = b.AvailableCopies,
                    ISBN = b.ISBN,
                    CreateDate = b.CreateDate,
                    ChangeDate = b.ChangeDate,
                    DeleteDate = b.DeleteDate
                });

            return View(books);
        }
    }
}
