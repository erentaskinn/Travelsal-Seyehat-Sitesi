using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Travel_DataAccessLayer.Abstract;
using Travel_DataAccessLayer.Concerate;

namespace Travel_DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T T)
        {
            using var c = new Context();
            c.Remove(T);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c=new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> fiter)
        {
            using var c=new Context();
            return c.Set<T>().Where(fiter).ToList();
        }

        public void Intert(T T)
        {
            using var c = new Context();
            c.Add(T);
            c.SaveChanges();
        }

        public void Update(T T)
        {
            using var c = new Context();
            c.Update(T);
            c.SaveChanges();
        }
    }
}
