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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal; // DAL içerisindeki metoda erişmek için injection yöntemi uyguladık.
        }

        public void AddWriterBL(Writer writer)
        {
            writer.WriterStatus = true;
            _writerDal.Insert(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer GetByAuthentication(Writer writer)
        {
            return _writerDal.List().FirstOrDefault(x => x.WriterEmail == writer.WriterEmail && x.WriterPassword == writer.WriterPassword);
        }

        public Writer GetById(int id)
        {
            return _writerDal.Get(x => x.WriterId == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }

        public List<Writer> GetListByNickNameContains(string character)
        {
            return _writerDal.List(x=>x.NickName.Contains(character));
        }

        public void UpdateWriter(Writer writer)
        {
            _writerDal.Update(writer);
        }

        public int WriterIdInfo(string p)
        {
            return _writerDal.List().Where(x => x.WriterEmail == p).Select(y => y.WriterId).FirstOrDefault();
        }
    }
}
