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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment T)
        {
            _commentDal.Intert(T);
        }

        public void TDelete(Comment T)
        {
            _commentDal.Delete(T);
        }

        public Comment TGetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }
        public List<Comment> TGetDestinationById(int Id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationId == Id);
        }
        public void TUpdate(Comment T)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetByFilter(Expression<Func<Comment, bool>> fiter)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int Id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(Id);
        }
    }
}
