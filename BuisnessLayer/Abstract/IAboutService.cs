using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AddAboutBL(About about);
        void DeleteAbout(About about);
        void UpdateAbout(About about);
        About GetById(int id);
    }
}
