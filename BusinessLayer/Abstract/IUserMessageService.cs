using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUsersMessageService : IGenericService<UserMessage>
    {
        List<UserMessage> GetListSenderMessage ( string p );
        List<UserMessage> GetListReceiverMessage ( string p );

        List<UserMessage> GetListDeleteMessage ();


    }
}
