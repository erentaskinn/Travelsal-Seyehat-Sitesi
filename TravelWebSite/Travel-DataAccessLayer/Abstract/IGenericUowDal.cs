using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void Intert(T T);
 
        void Update(T T);
        void MultiUpdate(List<T> T);
        T GetbyId(int id);
       
    }
}
