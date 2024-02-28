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
    public class GuidManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuidManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide T)
        {
            _guideDal.Intert(T);
        }

        public void TChangeToFalseByGuide(int Id)
        {
            _guideDal.ChangeToFalseByGuide(Id);
        }

        public void TChangeToTrueByGuide(int Id)
        {
            _guideDal.ChangeToTrueByGuide(Id);
        }

        public void TDelete(Guide T)
        {
           _guideDal.Delete(T);
        }

        public List<Guide> TGetByFilter(Expression<Func<Guide, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
          return _guideDal.GetById(id);
        }

        public List<Guide> TGetList()
        {
             return _guideDal.GetList();
        }

        public void TUpdate(Guide T)
        {
            _guideDal.Update(T);
        }
    }
}
