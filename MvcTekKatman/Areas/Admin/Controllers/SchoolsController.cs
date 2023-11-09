using Microsoft.AspNetCore.Mvc;
using MvcTekKatman.Entities;
using MvcTekKatman.Repositories.IRespository;
using MvcTekKatman.ViewModels.SchoolVms;

namespace MvcTekKatman.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchoolsController : Controller
    {
        private readonly ISchoolRepository _repo;
        public SchoolsController(ISchoolRepository repo)
        {
            _repo = repo;
        }

        // GET: Schools
        public ActionResult Index()
        {
            List<SchoolListvm> schools = _repo.GetAll().Select(x => new SchoolListvm
            {
                SchoolId = x.Id,
                SchoolName = x.SchoolName
            }).ToList();

            return View(schools);
        }

        // GET: Schools/Details/5
        public ActionResult Details(int id)
        {
            School school = _repo.GetById(id);

            SchoolDetailVm vm = new SchoolDetailVm
            {
                SchoolName = school.SchoolName,
                CreateDate = school.CreateDate
            };

            return View(vm);
        }

        // GET: Schools/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SchoolCreateVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            School school = new School
            {
                SchoolName = model.Schoolname,
                CreateDate = DateTime.Now
            };

            _repo.Create(school);

            return RedirectToAction(nameof(Index));
        }

        // GET: Schools/Edit/5
        public ActionResult Edit(int id)
        {
            var school = _repo.GetById(id);

            SchoolUpdateVm vm = new SchoolUpdateVm
            {
                Id = school.Id,
                SchoolName = school.SchoolName
            };

            return View(vm);
        }

        // POST: Schools/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SchoolUpdateVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var school = _repo.GetById(model.Id);
            school.SchoolName = model.SchoolName;
            school.UpdateDate = DateTime.Now;

            _repo.Update(school);

            return RedirectToAction(nameof(Index));
        }

        // GET: Schools/Delete/5
        public ActionResult Delete(int id)
        {
            var school = _repo.GetById(id);

            if (school != null)
            {
                _repo.Delete(school);
            }

            return RedirectToAction("Index");
        }


    }
}
