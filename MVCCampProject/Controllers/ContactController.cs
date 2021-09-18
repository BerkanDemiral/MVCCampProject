using BuisnessLayer.Concrete;
using BuisnessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator();
        public ActionResult Index()
        {
            var contactValues = contactManager.GetList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id) // mesaja tıklandığı anda aynı sayfada detaylarını göstereceğiz
        {
            var ContactValues = contactManager.GetById(id);
            return View(ContactValues);   
        }

        [HttpGet]
        public ActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMessage(Contact contact)
        {

            return View();
        }

        public PartialViewResult IndexPartial()
        {
            return PartialView();
        }

        public ActionResult GetMessageDetail(int id)
        {
            var messageValue = contactManager.GetById(id);
            return View(messageValue);
        }
    }
}