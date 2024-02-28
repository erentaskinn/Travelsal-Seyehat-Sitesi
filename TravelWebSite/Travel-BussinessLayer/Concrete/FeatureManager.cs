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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature T)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature T)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetByFilter(Expression<Func<Feature, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public void TUpdate(Feature T)
        {
            throw new NotImplementedException();
        }
    }
}
