using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
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


        public ActionResult MyContent(string p)  
        {
            int id;
            p = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(p);
            var contentValues = contentManager.GetListByWriter(id);
            return View(contentValues);
        }
    }
}