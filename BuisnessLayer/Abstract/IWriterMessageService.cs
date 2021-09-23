using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IWriterMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendBox();
        void AddMessageBL(Message message);
        void DeleteMessage(Message message);
        void UpdateMessage(Message message);
        Message GetById(int id);
    }
}
