using GameRecruitment.Models;
using GameRecruitment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameRecruitment.Controllers
{
    public class CompanyInfosController : Controller
    {
        private readonly CompanyInfosRepository _repository;
        public CompanyInfosController(CompanyInfosRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var company = _repository.GetAllCompanies();
            return View("Index",company);
        }
        public IActionResult Details(Guid id) 
        {
            CompanyInfoModel model = _repository.GetCompaniesById(id);
            return View("Details",model);
        }
        public IActionResult Create() 
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(IFormCollection collection)
        {
            var model= new CompanyInfoModel();
            TryUpdateModelAsync(model);
            _repository.Add(model);
            return RedirectToAction("Index");
        }
    }
}
