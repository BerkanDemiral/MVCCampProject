using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content

        ContentManager contentManager = new ContentManager(new EfContentDal());

        
        public ActionResult Index()
        {
            var ContentValues =  contentManager.GetList();
            return View(ContentValues);
        }

        public ActionResult ContentByHeading(int id)
        {
            var valuesByHeading = contentManager.GetListByHeadingID(id);
            return View(valuesByHeading);
        }
    }
}