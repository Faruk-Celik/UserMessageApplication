using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using EntitiyLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUsersMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
    }
}
