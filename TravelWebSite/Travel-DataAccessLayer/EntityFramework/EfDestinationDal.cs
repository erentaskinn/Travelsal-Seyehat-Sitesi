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
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int Id)
        {
            using (var c=new Context())
            {
                return c.Destinations.Where(x=>x.DestinationId==Id).Include(x=>x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetLast4Destinations()
        {
            using (var contex = new Context())
            {
                var values=contex.Destinations.Take(4).OrderByDescending(x=>x.DestinationId).ToList();
                return values;
            }
        }
    }
}
