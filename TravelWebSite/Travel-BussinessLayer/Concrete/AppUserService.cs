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
    public class AppUserService : IAppUserService
    {
       private readonly IAppUserDal _AppUserDal;
        public AppUserService(IAppUserDal appUserDal)
        {
            _AppUserDal = appUserDal;
        }
        public void TAdd(AppUser T)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser T)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetByFilter(Expression<Func<AppUser, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _AppUserDal.GetList();
        }

        public void TUpdate(AppUser T)
        {
            throw new NotImplementedException();
        }
    }
}
