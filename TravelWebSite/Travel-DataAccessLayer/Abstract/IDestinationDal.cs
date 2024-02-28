using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int Id);
        public List<Destination> GetLast4Destinations();
    }
}
