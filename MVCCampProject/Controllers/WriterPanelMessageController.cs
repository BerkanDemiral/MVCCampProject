using BuisnessLayer.Concrete;
using BuisnessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();


        public ActionResult Inbox(string word)
        {
            string p = (string)Session["WriterEmail"];
            var inboxValues = messageManager.GetListInbox(p, word);
            return View(inboxValues);
        }

        public ActionResult SendBox(string word)
        {
            string p = (string)Session["WriterEmail"];
            var sendBoxValues = messageManager.GetListSendBox(p, word);
            return View(sendBoxValues);
        }

        public ActionResult GetMessageDetail(int id)
        {
            var messageValue = messageManager.GetById(id);
            return View(messageValue);
        }

        public PartialViewResult IndexPartial()
        {
            string p = (string)Session["WriterEmail"];

            var numberOfInbox = messageManager.GetListInbox(p).Count();
            ViewBag.inbox = numberOfInbox;

            var numberOfSendBox = messageManager.GetListSendBox(p).Count();
            ViewBag.sendBox = numberOfSendBox;

            return PartialView();
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messageValidator.Validate(p);
            string email = (string)Session["WriterEmail"];

            if (results.IsValid)
            {
                p.SenderMail = email;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                messageManager.AddMessageBL(p);
                return RedirectToAction("SendBox");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}