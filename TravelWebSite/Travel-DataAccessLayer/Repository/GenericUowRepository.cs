using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_DataAccessLayer.Abstract;
using System.Collections.Generic;
using Travel_DataAccessLayer.Concerate;

namespace Travel_DataAccessLayer.Repository
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly Context _context;
        public GenericUowRepository(Context context)
        {
            _context = context;
        }

        public T GetbyId(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public void Intert(T T)
        {
            _context.Add(T);
        }

        public void MultiUpdate(List<T> T)
        {
            _context.UpdateRange(T);
        }

        public void Update(T T)
        {
            _context.Update(T);
        }
    }
}
