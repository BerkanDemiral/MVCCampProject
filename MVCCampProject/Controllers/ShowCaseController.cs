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
    [AllowAnonymous]
    public class ShowCaseController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult HomePage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterWriter(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);

            if (results.IsValid)
            {
                writer.WriterStatus = true;
                writerManager.AddWriterBL(writer);
                return RedirectToAction("WriterLogin", "Login");
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