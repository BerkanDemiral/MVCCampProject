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
    public class WriterPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        int id;
        public ActionResult MyContent(string p)  
        {
            
            p = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(p);
            var contentValues = contentManager.GetListByWriter(id);
            return View(contentValues);
        }

        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.headingId = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content content)
        {
            string mail = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(mail);

            content.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            content.WriterId = id;
            content.ContentStatus = true;

            contentManager.ContentAddBL(content);
            return RedirectToAction("MyContent");
        }
    }
}