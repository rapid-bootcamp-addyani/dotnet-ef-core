using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetEfCore.Controllers
{
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public InventoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<InventoryEntity> categories = _context.InventoryEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            InventoryEntity inventory = _context.InventoryEntities.Find(id);
            return View(inventory);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Name, Specification, Quantity, OnLoan, Ready")] InventoryEntity request)
        {
            _context.InventoryEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.InventoryEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.InventoryEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.InventoryEntities.Remove(entity);
            _context.SaveChanges();

            return Redirect("/Inventory/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,Name, Specification, Quantity, OnLoan, Ready")] InventoryEntity request)
        {
            _context.InventoryEntities.Update(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }
    }
}
