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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBL(Content content)
        {
            _contentDal.Insert(content);
        }

        public void DeleteContent(Content p)
        {
            _contentDal.Delete(p);
        }

        public Content GetById(int id)
        {
            return _contentDal.Get(x => x.ContentId == id);
        }

        public List<Content> GetList()
        {
            return _contentDal.List();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingId == id); // birden çok değer listeleneceği için LİST kullandık !!!
            // content dal içerisinde parametreli bir list metodu daha var (ezme) bu sayede bunu kullanabiliyoruz. 
        }

        public void UpdateContent(Content p)
        {
            _contentDal.Update(p);
        }
    }
}
