using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotnetEfCore.Controllers
{
    public class AbsensiController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AbsensiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<AbsensiEntity> categories = _context.AbsensiEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            AbsensiEntity absensi = _context.AbsensiEntities.Find(id);
            return View(absensi);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("EmployeeId, AbsentStartDate, AbsentEndDate, Location, Description")] AbsensiEntity request)
        {
            _context.AbsensiEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.AbsensiEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.AbsensiEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.AbsensiEntities.Remove(entity);
            _context.SaveChanges();

            return Redirect("/Absensi/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,EmployeeId, AbsentStartDate, AbsentEndDate, Location, Description")] AbsensiEntity request)
        {
            _context.AbsensiEntities.Update(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }
    }
}
