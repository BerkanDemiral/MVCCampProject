using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        ImageFileManager imageManager = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var ImageValues = imageManager.GetList();
            return View(ImageValues);
        }
    }
}