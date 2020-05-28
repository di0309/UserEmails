using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserEmails.DAL;
using UserEmails.Models;

namespace UserEmails.Controllers
{
    public class HomeController : Controller
    {
        UserEmailsContext db = new UserEmailsContext();
        public ActionResult Index()
        {
            int selectedIndex = 1;
            SelectList users = new SelectList(db.Users, "Id", "Name", selectedIndex);
            ViewBag.Users = users;
            var emails = db.Emails.Where(c => c.UserID == selectedIndex);
            ViewBag.Emails = emails;
            return View();
        }
        public ActionResult GetEmails(int id)
        {
            return PartialView(db.Emails.Where(c => c.UserID == id).ToList());
        }

        [HttpPost]
        public JsonResult AddEmail(Email email)
        {
            try
            {
                db.Emails.Add(email);
                db.SaveChanges();
                return Json(new { success = true, message = "ok" });
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}