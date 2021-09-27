using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {

        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        public ActionResult Headings()
        {
            var headingList = headingManager.GetList();
            return View(headingList);
        }

        public PartialViewResult Index(int id=0) // ekran açıldığı anda hata vermemesi için
        {
            var contentValues = contentManager.GetListByHeadingID(id );
            return PartialView(contentValues);
        }
    }
}