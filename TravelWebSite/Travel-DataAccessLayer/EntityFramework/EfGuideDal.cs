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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int Id)
        {
           
            var values = context.Guides.Find(Id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int Id)
        {
           
            var values = context.Guides.Find(Id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
