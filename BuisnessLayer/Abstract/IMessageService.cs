using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendBox(string p);
        List<Message> GetListInbox(string p, string word);
        List<Message> GetListSendBox(string p, string word);
        void AddMessageBL(Message message);
        void DeleteMessage(Message message);
        void UpdateMessage(Message message);
        Message GetById(int id);
    }
}
