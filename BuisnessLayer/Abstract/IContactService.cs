using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        void AddContactBL(Contact contact);
        void DeleteContact(Contact contact);
        void UpdateContact(Contact contact);
        Contact GetById(int id);
    }
}
