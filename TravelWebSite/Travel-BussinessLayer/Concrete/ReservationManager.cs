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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Rezervation> GetListWithReservationByAccepted(int Id)
        {
            return _reservationDal.GetListWithReservationByAccepted(Id);
        }

        public List<Rezervation> GetListWithReservationByPrevious(int Id)
        {
            return _reservationDal.GetListWithReservationByPrevious(Id);
        }

        public List<Rezervation> GetListWithReservationByWaitApproval(int Id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(Id);
        }

        public void TAdd(Rezervation T)
        {
            _reservationDal.Intert(T);
        }

        public void TDelete(Rezervation T)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> TGetByFilter(Expression<Func<Rezervation, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public Rezervation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rezervation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rezervation T)
        {
            throw new NotImplementedException();
        }
    }
}
