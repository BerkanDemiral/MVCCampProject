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
    public class WriterPanelHeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());


        public ActionResult WriterProfile()
        {
            return View();
        }

        public ActionResult MyHeading(string p)
        {
            int id;
            p = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(p);
            var headinValues = headingManager.GetListByWriter(id);
            return View(headinValues);
        }

        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName, //DisplayMember -- ekranda görüncecek yer
                                                      Value = x.CategoryId.ToString() // ValueMember -- arkada tutulacak değer
                                                  }).ToList();
            ViewBag.valueCategory_ = valueCategory;

            return View();
        }

        [HttpPost]
        public ActionResult NewHeading(Heading heading, string p)
        {
            int id;
            p = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(p);

            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            heading.WriterId = id;
            heading.HeadingStatus = true;
            headingManager.AddHeadingBL(heading);
            return RedirectToAction("MyHeading");

        }

        [HttpGet]
        public ActionResult UpdateHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName, //DisplayMember -- ekranda görüncecek yer
                                                      Value = x.CategoryId.ToString() // ValueMember -- arkada tutulacak değer
                                                  }).ToList();
            ViewBag.valueCategory_ = valueCategory;

            var HeadingValue = headingManager.GetById(id);
            return View(HeadingValue);
        }

        [HttpPost]
        public ActionResult UpdateHeading(Heading heading)
        {
            headingManager.UpdateHeading(heading);
            heading.HeadingStatus = true;
            return RedirectToAction("MyHeading");
        }

        public ActionResult DeleteHeading(int id)
        {
            Heading heading = headingManager.GetById(id);
            heading.HeadingStatus = false;
            headingManager.DeleteHeading(heading);
            return RedirectToAction("MyHeading");
        }

    }
}