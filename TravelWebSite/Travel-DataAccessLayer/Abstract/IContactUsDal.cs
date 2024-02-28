using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IContactUsDal:IGenericDal<ContactUs>
    {
        List<ContactUs> GetListByTrue();
        List<ContactUs> GetListByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
