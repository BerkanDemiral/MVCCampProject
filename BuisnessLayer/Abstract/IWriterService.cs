using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        List<Writer> GetListByNickNameContains(string character);
        void AddWriterBL(Writer writer);
        void DeleteWriter(Writer writer);
        void UpdateWriter(Writer writer);
        Writer GetById(int id);
        Writer GetByAuthentication(Writer writer);
        int WriterIdInfo(string p);


    }
}
