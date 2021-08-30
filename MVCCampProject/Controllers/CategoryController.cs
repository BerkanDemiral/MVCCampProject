using BuisnessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var CategoryValues = cm.GetAll();
            return View(CategoryValues);
        }


    }
}