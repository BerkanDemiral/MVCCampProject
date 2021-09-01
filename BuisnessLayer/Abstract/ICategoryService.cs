using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    interface ICategoryService 
    {
        List<Category> GetList();
        void CategoryAddBL(Category category);
    }
}
