using System.Web.Mvc;
using Library.Data.Repositories;

namespace Library.Web.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionsRepository _positionRepository;

        public PositionController(IPositionsRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        [Authorize(Roles = "Admin, Manager")]
        public ActionResult Index()
        {
            var positions = _positionRepository.GetAllPositions();
            return View(positions);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Position position)
        {
            if (ModelState.IsValid)
            {
                _positionRepository.AddPosition(position);
                return RedirectToAction(nameof(Index));
            }
            return View(position);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var position = _positionRepository.GetPositionById(id);
            if (position == null)
            {
                return HttpNotFound();
            }
            return View(position);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Position position)
        {
            if (ModelState.IsValid)
            {
                _positionRepository.UpdatePosition(position);
                return RedirectToAction(nameof(Index));
            }
            return View(position);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            _positionRepository.DeletePosition(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
