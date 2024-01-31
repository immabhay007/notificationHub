using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace notificationHub.Controllers
{
    public class HomeController : Controller
    {
        notificationHubDBEntities _context = new notificationHubDBEntities();
        public ActionResult Index()
        {
            var listofData = _context.notification_tbl.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            var data = _context.notification_tbl.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        public ActionResult Delete(int id)
        {
            var data = _context.notification_tbl.Where(x => x.Id == id).FirstOrDefault();
            _context.notification_tbl.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Notification Deleted";
            return RedirectToAction("index");
        }



    }
}