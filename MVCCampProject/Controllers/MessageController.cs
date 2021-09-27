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
    [Authorize]
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        MessageValidator messageValidator = new MessageValidator();
        //ValidationResult result = messageValidator.Validate(message);

        [HttpGet]
        public ActionResult Inbox()
        {
            string p = (string)Session["AdminUserName"];
            var inboxValues = messageManager.GetListInbox(p);
            return View(inboxValues);
        }

        [HttpPost]
        public ActionResult Inbox(string word)
        {
            string p = (string)Session["AdminUserName"];
            var inboxValues = messageManager.GetListInbox(p, word);
            return View(inboxValues);
        }

        [HttpGet]
        public ActionResult SendBox()
        {
            string p = (string)Session["AdminUserName"];
            var sendBoxValues = messageManager.GetListSendBox(p);
            return View(sendBoxValues);
        }

        [HttpPost]
        public ActionResult SendBox(string word)
        {
            string p = (string)Session["AdminUserName"];
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
            string p = (string)Session["AdminUserName"];
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
            string email = (string)Session["AdminUserName"];
            ValidationResult results = messageValidator.Validate(p);
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