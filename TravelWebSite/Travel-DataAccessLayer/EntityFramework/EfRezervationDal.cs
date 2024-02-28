using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_DataAccessLayer.Abstract;
using Travel_DataAccessLayer.Concerate;
using Travel_DataAccessLayer.Repository;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.EntityFramework
{
    public class EfRezervationDal : GenericRepository<Rezervation>, IReservationDal
    {
        public List<Rezervation> GetListWithReservationByAccepted(int Id)
        {
            using (var context = new Context())
            {
                return context.Rezervations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == Id).ToList();
            }
        }

        public List<Rezervation> GetListWithReservationByPrevious(int Id)
        {
            using (var context = new Context())
            {
                return context.Rezervations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == Id).ToList();
            }
        }

        public List<Rezervation> GetListWithReservationByWaitApproval(int Id)
        {
           using (var context =new Context())
            {
                return context.Rezervations.Include(x=>x.Destination).Where(x=>x.Status=="Onay Bekliyor" &&x.AppUserId==Id).ToList();
            }
        }
    }
}
