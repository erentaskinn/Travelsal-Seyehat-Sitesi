using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_BussinessLayer.Abstract.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void TIntert(T T);
        void TUpdate(T T);
        void TMultiUpdate(List<T> T);
        T TGetbyId(int id);
    }
}
