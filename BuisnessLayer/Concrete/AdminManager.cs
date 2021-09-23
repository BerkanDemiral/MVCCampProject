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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddAdminBL(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public Admin GetByAuthentication(Admin admin)
        {
            return _adminDal.List().FirstOrDefault(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x=>x.AdminId == id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.List();
        }

        public void UpdateAdmin(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
