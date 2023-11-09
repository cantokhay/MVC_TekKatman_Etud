using Microsoft.AspNetCore.Mvc;
using MvcTekKatman.Entities;
using MvcTekKatman.Repositories.IRespository;

namespace MvcTekKatman.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminsController : Controller
    {
        private readonly IUserRepository _repo;
        public AdminsController(IUserRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int id)
        {
            User user = _repo.GetById(id);

            return View();
        }
    }
}
