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
    }
}
