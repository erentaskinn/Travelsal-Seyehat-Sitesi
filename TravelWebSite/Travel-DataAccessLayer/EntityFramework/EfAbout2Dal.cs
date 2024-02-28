using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel_DataAccessLayer.Abstract;
using Travel_DataAccessLayer.Repository;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.EntityFramework
{
    public class EfAbout2Dal: GenericRepository<About2>, IAbout2Dal
    {
    }
}
