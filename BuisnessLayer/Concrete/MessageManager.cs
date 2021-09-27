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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void AddMessageBL(Message message)
        {
            _messageDal.Insert(message);
        }

        public void DeleteMessage(Message message)
        {
            _messageDal.Update(message);
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);
        }

        public List<Message> GetListInbox(string p)
        {
            return _messageDal.List(x => x.RecieverMail == p);
        }

        public List<Message> GetListInbox(string p, string word)
        {
            return _messageDal.List(x => x.RecieverMail == p && x.MessageContent.Contains(word));
        }

        public List<Message> GetListSendBox(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }

        public List<Message> GetListSendBox(string p, string word)
        {
            return _messageDal.List(x => x.SenderMail == p && x.MessageContent.Contains(word));
        }

        public void UpdateMessage(Message message)
        {
            _messageDal.Update(message);
        }
    }
}
