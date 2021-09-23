using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AddAdminBL(Admin admin);
        void UpdateAdmin(Admin admin);
        Admin GetById(int id);
        Admin GetByAuthentication(Admin admin);
    }
}
