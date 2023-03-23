using GameRecruitment.Models;
using GameRecruitment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameRecruitment.Controllers
{
    public class TesterInfosController : Controller
    {
        private readonly TesterInfosRepository _repository;
        public TesterInfosController(TesterInfosRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var testers = _repository.GetAllTesters();
            return View("Index",testers);
        }
        public IActionResult Create()
        {
           return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection collection) { 
            TesterInfoModel model = new TesterInfoModel();
            TryUpdateModelAsync(model);
            _repository.Add(model);
            return RedirectToAction("Index");
            
        }
        public IActionResult Details(Guid id)
        {
            TesterInfoModel model=_repository.GetTesterByID(id);
            return View("Details", model);
        }
        public IActionResult Edit(Guid id)
        {
            TesterInfoModel model = _repository.GetTesterByID(id);
            return View("Edit", model);
        }
        [HttpPost]
        public IActionResult Edit(IFormCollection collection, Guid id) 
        {
            TesterInfoModel model= new TesterInfoModel();
            TryUpdateModelAsync(model);
            _repository.Update(model);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id) 
        {
            TesterInfoModel model= _repository.GetTesterByID(id);
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
