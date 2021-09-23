using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void AddHeadingBL(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void DeleteHeading(Heading heading)
        { 
            _headingDal.Update(heading);
        }

        public Heading GetById(int id)
        {
            return _headingDal.Get(x => x.HeadingId == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List(x=>x.HeadingStatus==true);
        }

        public List<Heading> GetListByCategoryName(string categoryName)
        {
            return _headingDal.List(x=>x.Category.CategoryName == categoryName);
        }

        public List<Heading> GetListByWriter(int id)
        {
            return _headingDal.List(x => x.WriterId == id && x.HeadingStatus == true);
        }

        public void UpdateHeading(Heading heading)
        {
            _headingDal.Update(heading);
        }
    }
}
