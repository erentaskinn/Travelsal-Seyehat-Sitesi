using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Travel_BussinessLayer.Abstract;
using Travel_DataAccessLayer.Abstract;
using Travels_EntityLayer.Concrete;

namespace Travel_BussinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
           _aboutDal = aboutDal;
        }
        public void TAdd(About T)
        {
            _aboutDal.Intert(T);
        }

        public void TDelete(About T)
        {
            _aboutDal.Delete(T);
        }

        public List<About> TGetByFilter(Expression<Func<About, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }

        public void TUpdate(About T)
        {
            _aboutDal.Update(T);
        }
    }
}
