using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter(int id);
        List<Heading> GetListByCategoryName(string categoryName);
        void AddHeadingBL(Heading heading);
        void DeleteHeading(Heading heading);
        void UpdateHeading(Heading heading);
        Heading GetById(int id);

    }
}
