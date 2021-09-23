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
        public ActionResult Headings()
        {
            var headingList = headingManager.GetList();
            return View(headingList);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}