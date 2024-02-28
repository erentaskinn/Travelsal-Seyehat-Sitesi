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
    public class EfAccountDal:GenericUowRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context):base (context)
        {
            
        }
    }
}
