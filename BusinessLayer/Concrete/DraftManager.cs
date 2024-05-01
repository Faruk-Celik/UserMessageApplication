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
    public class DraftManager : IDraftService
    {
        IDraftDal _draftDal;

        public DraftManager ( IDraftDal draftDal )
        {
            _draftDal = draftDal;
        }

        public void TDelete ( int id )
        {
            throw new NotImplementedException();
        }

        public Draft TGetById ( int id )
        {
            throw new NotImplementedException();
        }

        public List<Draft> TGetListAll ()
        {
            throw new NotImplementedException();
        }

        public void TInsert ( Draft t )
        {
            throw new NotImplementedException();
        }

        public void TUpdate ( Draft t )
        {
            throw new NotImplementedException();
        }
    }
}
