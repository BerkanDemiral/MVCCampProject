using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
        void ContentAddBL(Content content);
        Content GetById(int id);
        void DeleteContent(Content p);
        void UpdateContent(Content p);
    }
}
