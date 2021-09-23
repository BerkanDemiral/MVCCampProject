using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System.Web.Mvc;

namespace MVCCampProject.Controllers
{
    public class StatisticController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        Heading heading;
        public ActionResult LinqCarts()
        {
            var numberOfWriters = writerManager.GetList().Count;
            ViewBag.numberOfWriters_ = numberOfWriters;

            var numberOfHeadings = headingManager.GetListByCategoryName("Spor").Count;
            ViewBag.numberOfHeadings_ = numberOfHeadings;

            var numberOfContent = contentManager.GetList().Count;
            ViewBag.numberOfContent_ = numberOfContent;

            var numberOfCategories = categoryManager.GetList().Count;
            ViewBag.numberOfCategories_ = numberOfCategories;

            var writerNickNameForChar = writerManager.GetListByNickNameContains("a").Count;
            ViewBag.writerNickNameForChar_ = writerNickNameForChar;

            var trueStatus = categoryManager.GetListStatusTrue().Count;
            ViewBag.trueStatus_ = trueStatus;

            var falseStatus = categoryManager.GetListStatusFalse().Count;
            ViewBag.falseStatus_ = falseStatus;

            var statusDifference = (categoryManager.GetListStatusTrue().Count) - (categoryManager.GetListStatusFalse().Count);
            ViewBag.statusDifference_ = statusDifference;

            return View();
        }

        
    }
}