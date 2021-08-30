using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class CategoryManager
    {
        // 2 katmanı da kullandık**** UNUTMA DAL'daki concrete içerisindeki sınıfa bağlı olarak oluşturduk Interface'e değil.
        GenericRepository<Category> repo = new GenericRepository<Category>();

        // tüm değerleri getir -- normal List
        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName == "" || p.CategoryName.Length<=3 || p.CategoryDetail == "")
            {
                // hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
