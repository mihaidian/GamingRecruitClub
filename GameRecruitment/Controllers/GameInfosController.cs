using GameRecruitment.Models;
using GameRecruitment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameRecruitment.Controllers
{
    public class GameInfosController : Controller
    {
        private readonly GameInfosRepository _repository;
        public GameInfosController(GameInfosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var games = _repository.GetGameInfos();
            return View("Index",games);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection collection) 
        {
            GameInfoModel model = new GameInfoModel();
            TryUpdateModelAsync(model);
            _repository.Add(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details( Guid id)
        {
            GameInfoModel model = _repository.GetGameByID(id);
            return View("Details",model);
            
        }
        public IActionResult Edit(Guid id) 
        {
            GameInfoModel model= _repository.GetGameByID(id);
            return View("Edit", model);
        }
        [HttpPost]
        public IActionResult Edit(Guid id, IFormCollection collection)
        {
            GameInfoModel model = new GameInfoModel();
            TryUpdateModelAsync(model);
            _repository.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            GameInfoModel model=_repository.GetGameByID(id);
            return View("Delete", model);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection collection,Guid id)
        {
_repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
