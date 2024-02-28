using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Intert(T T);
        void Delete(T T);
        void Update(T T);
        List<T> GetList();
        T GetById(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> fiter);
    }
}
