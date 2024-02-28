using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_BussinessLayer.Abstract.AbstractUow;
using Travel_DataAccessLayer.Abstract;
using Travel_DataAccessLayer.UnitOfWork;
using Travels_EntityLayer.Concrete;

namespace Travel_BussinessLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;
        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public Account TGetbyId(int id)
        {
          return  _accountDal.GetbyId(id);
        }

        public void TIntert(Account T)
        {
            _accountDal.Intert(T);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Account> T)
        {
            _accountDal.MultiUpdate(T);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Account T)
        {
            _accountDal.Update(T);
            _unitOfWorkDal.Save();
        }
    }
}
