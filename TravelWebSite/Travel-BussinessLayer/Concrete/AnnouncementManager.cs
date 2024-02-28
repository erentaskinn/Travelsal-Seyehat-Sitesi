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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }
        public void TAdd(Announcement T)
        {
            _announcementDal.Intert(T);
        }

        public void TDelete(Announcement T)
        {
            _announcementDal.Delete(T);
        }

        public List<Announcement> TGetByFilter(Expression<Func<Announcement, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public void TUpdate(Announcement T)
        {
            _announcementDal.Update(T);
        }
    }
}
