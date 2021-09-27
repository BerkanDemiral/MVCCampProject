using BuisnessLayer.Concrete;
using BuisnessLayer.ValidationRules;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class WriterPanelProfileController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        int id;

        [HttpGet]
        public ActionResult WriterProfile()
        {
      
            string p = (string)Session["WriterEmail"];
            id = writerManager.WriterIdInfo(p);

            var writerValue = writerManager.GetById(id);
            return View(writerValue);
        }

        [HttpPost]
        public ActionResult WriterProfile(Writer writer)
        {

            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);

            if (results.IsValid)
            {
                writerManager.UpdateWriter(writer);
                return RedirectToAction("AllHeading","WriterPanelHeading");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


        }
    }
}