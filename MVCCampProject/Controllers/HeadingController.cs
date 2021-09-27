using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace MVCCampProject.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index(int p=1)
        {
            var HeadingValues = headingManager.GetList().ToPagedList(p, 7); ;
            return View(HeadingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName, //DisplayMember -- ekranda görüncecek yer
                                                      Value = x.CategoryId.ToString() // ValueMember -- arkada tutulacak değer
                                                  }).ToList();
            ViewBag.valueCategory_ = valueCategory;

            List<SelectListItem> valueWriter = (from x in writerManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.NickName, //DisplayMember -- ekranda görüncecek yer
                                                      Value = x.WriterId.ToString() // ValueMember -- arkada tutulacak değer
                                                  }).ToList();
            ViewBag.valueWriter_ = valueWriter;

            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {

            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headingManager.AddHeadingBL(heading);
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int id)
        {
            Heading heading = headingManager.GetById(id);
            heading.HeadingStatus = false;
            headingManager.DeleteHeading(heading);
            return RedirectToAction("Index");
        }

        public ActionResult HeadingReport()
        {
            var HeadingValues = headingManager.GetList();
            return View(HeadingValues);
        }
    }
}