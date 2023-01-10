using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotnetEfCore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<EmployeeEntity> categories = _context.EmployeeEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            EmployeeEntity employee = _context.EmployeeEntities.Find(id);
            return View(employee);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Name, Email, Address, Phone, Position")] EmployeeEntity request)
        {
            _context.EmployeeEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.EmployeeEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.EmployeeEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.EmployeeEntities.Remove(entity);
            _context.SaveChanges();

            return Redirect("/Employee/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,Name, Email, Address, Phone, Position")] EmployeeEntity request)
        {
            _context.EmployeeEntities.Update(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }
    }
}
