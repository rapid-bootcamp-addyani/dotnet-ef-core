using DotnetEfCore.DataContext;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotnetEfCore.Controllers
{
    public class MailboxController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MailboxController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<MailboxEntity> categories = _context.MailboxEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            MailboxEntity mailbox = _context.MailboxEntities.Find(id);
            return View(mailbox);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Username, ToRecipients, CCRecipients, Subject, Body, Attachment, Scheduled, StatusDone")] MailboxEntity request)
        {
            _context.MailboxEntities.Add(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.MailboxEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.MailboxEntities.Find(id);
            if (entity == null)
            {
                return Redirect("GetAll");
            }
            _context.MailboxEntities.Remove(entity);
            _context.SaveChanges();

            return Redirect("/Mailbox/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id,Username, ToRecipients, CCRecipients, Subject, Body, Attachment, Scheduled, StatusDone")] MailboxEntity request)
        {
            _context.MailboxEntities.Update(request);
            _context.SaveChanges();

            return Redirect("GetAll");
        }
    }
}
