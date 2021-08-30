using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> // t değeri yollanacak entity'i karşılayacak. --- BURASI GENERİC SINIF OLARAK GEÇER..
    {
        List<T> List(Expression<Func<T, bool>> filter); // ismi ayse olanları getir vs. gibi filtreleme yapabileceğiz. 
        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        List<T> List();
    }
}
