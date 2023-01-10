using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace DotnetEfCore.Controllers
{
    public class LoanInventoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoanInventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<LoanInventoryEntity> categories = _context.LoanInventoryEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            LoanInventoryEntity loanInventory = _context.LoanInventoryEntities.Find(id);
            return View(loanInventory);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("NameUser, NameAdmin, Detail, Status, Date")] LoanInventoryEntity request)
        {
            _context.LoanInventoryEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.LoanInventoryEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.LoanInventoryEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.LoanInventoryEntities.Remove(entity);
            _context.SaveChanges();

            return Redirect("/LoanInventory/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,NameUser, NameAdmin, Detail, Status, Date")] LoanInventoryEntity request)
        {
            _context.LoanInventoryEntities.Update(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }
    }
}
