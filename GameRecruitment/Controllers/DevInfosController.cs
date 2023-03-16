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
    }
}
