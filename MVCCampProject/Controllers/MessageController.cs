using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
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

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            messageManager.AddMessageBL(message);
            return RedirectToAction("Index");
        }
    }
}