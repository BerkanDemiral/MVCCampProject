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

        public ActionResult Inbox()
        {
            var inboxValues = messageManager.GetListInbox();
            return View(inboxValues);
        }

        public ActionResult SendBox()
        {
            var sendBoxValues = messageManager.GetListSendBox();
            return View(sendBoxValues);
        }

        public ActionResult GetMessageDetail(int id)
        {
            var messageValue = messageManager.GetById(id);
            return View(messageValue);
        }

        public PartialViewResult IndexPartial()
        {
            var numberOfInbox = messageManager.GetListInbox().Count();
            ViewBag.inbox = numberOfInbox;

            var numberOfSendBox = messageManager.GetListSendBox().Count();
            ViewBag.sendBox = numberOfSendBox;

            return PartialView();
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messageValidator.Validate(p);

            if (results.IsValid)
            {
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