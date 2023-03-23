using GameRecruitment.Models;
using GameRecruitment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameRecruitment.Controllers
{
    public class DevInfosController : Controller
    {
        private readonly DevInfosRepository _repository;
        public DevInfosController(DevInfosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var devs = _repository.GetAllDevs();
            return View("Index", devs);
        }
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create (IFormCollection collection)
        {
            DevInfoModel model = new DevInfoModel();
            TryUpdateModelAsync(model);
            _repository.Add(model);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            DevInfoModel model=_repository.GetDevsByID(id);
            return View("Details", model);
        }
        public IActionResult Edit(Guid id) 
        {
            DevInfoModel model = _repository.GetDevsByID(id);
            return View("Edit",model);
        }
        [HttpPost]
        public IActionResult Edit(Guid id,IFormCollection collection) 
        {
            DevInfoModel model= new DevInfoModel();
            TryUpdateModelAsync(model);
            _repository.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id) 
        {
            DevInfoModel model= _repository.GetDevsByID(id);
            return View("Delete", model);
        }
        [HttpPost]
        public IActionResult Delete(IFormCollection collection, Guid id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
