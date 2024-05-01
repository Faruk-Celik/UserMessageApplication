using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UsersMessageManager : IUsersMessageService
    {
        IUserMessageDal _userMessageDal;

        public UsersMessageManager ( IUserMessageDal userMessageDal )
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetListDeleteMessage ()
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetListReceiverMessage ( string p )
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetListSenderMessage ( string p )
        {
            throw new NotImplementedException();
        }

        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public UserMessage TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public void TInsert ( UserMessage t )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( UserMessage t )
        {
            throw new NotImplementedException();
        }
    }
}
