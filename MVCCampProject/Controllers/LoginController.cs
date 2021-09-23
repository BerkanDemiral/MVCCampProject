using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MVCCampProject.Controllers
{

    [AllowAnonymous]
    public class LoginController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var adminValue = adminManager.GetByAuthentication(admin);
            if (adminValue != null)
            {
                FormsAuthentication.SetAuthCookie(adminValue.AdminUserName, false);
                Session["AdminUserName"] = adminValue.AdminUserName; // sisteme giriş yapan kişinin kullanıcı adını  aldık
                return RedirectToAction("Inbox","Message");
            }

            else
            {
                ViewBag.Message = "Kullanıcı Adı veya Parolanız Hatalı.";
                return View();
            }
        }

        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult WriterLogin(Writer writer)
        {
            var writerValue = writerManager.GetByAuthentication(writer);
            if (writerValue != null)
            {
                FormsAuthentication.SetAuthCookie(writerValue.WriterEmail, false);
                Session["WriterEmail"] = writerValue.WriterEmail; // sisteme giriş yapan kişinin kullanıcı adını  aldık
                return RedirectToAction("Inbox", "WriterPanelMessage");
            }

            else
            {
                ViewBag.Message = "Kullanıcı Adı veya Parolanız Hatalı.";
                return View();
            }
        }
    }
}