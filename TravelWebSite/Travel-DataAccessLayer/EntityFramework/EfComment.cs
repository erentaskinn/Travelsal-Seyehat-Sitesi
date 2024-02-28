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
    public class EfComment : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using (var c = new Context())
            {
                return c.Comments.Include(x=>x.Destination).ToList();
            }
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int Id)
        {
            using (var c = new Context())
            {
                return c.Comments.Where(x=>x.DestinationId==Id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
