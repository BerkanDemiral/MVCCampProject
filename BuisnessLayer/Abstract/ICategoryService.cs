using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetList();
        List<Category> GetListStatusTrue();
        List<Category> GetListStatusFalse();

        void CategoryAddBL(Category category);
        Category GetById(int id);
        void CategoryDelete(Category p);
        void CategoryUodate(Category p);
    }
}
