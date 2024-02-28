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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs T)
        {
            _contactUsDal.Intert(T);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs T)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetByFilter(Expression<Func<ContactUs, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> TGetListByFalse()
        {
            return _contactUsDal.GetListByFalse();
        }

        public List<ContactUs> TGetListByTrue()
        {
            return _contactUsDal.GetListByTrue();
        }

        public void TUpdate(ContactUs T)
        {
            throw new NotImplementedException();
        }
    }
}
