using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel_BussinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T T);
        void TDelete(T T);
        void TUpdate(T T);
        List<T> TGetList();
        T TGetById(int id);
        List<T> TGetByFilter(Expression<Func<T,bool>>fiter);
        
    }
}
