using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KullaniciGuncelleme.Models.Entity;

namespace KullaniciGuncelleme.Controllers
{
    public class UserController : Controller
    {
        FormExampleDBEntities1 db = new FormExampleDBEntities1();
        // GET: User
        public ActionResult Index()
        {         
            var degerler = db.Users.ToList();
            return View(degerler);
        }
        public ActionResult KullaniciGetir(int id)
        {
            var ktgr = db.Users.Find(id);
            return View("KullaniciGetir", ktgr);
        }

        public ActionResult Guncelle(Users p1)
        {
            var user = db.Users.Find(p1.UserID);
            user.UserName = p1.UserName;
            user.UserSurname = p1.UserSurname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
   
    }
}