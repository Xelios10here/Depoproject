
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SatilanUrunManager : ISatilanUrunService
    {
        ISatilanUrunDal _satilanUrunDal;

        public SatilanUrunManager(ISatilanUrunDal satilanUrunDal)
        {
            _satilanUrunDal = satilanUrunDal;
        }

        public SatilanUrun GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SatilanUrun> GetList()
        {
            return _satilanUrunDal.GetAll();
        }

        public void SatilanUrunAdd(SatilanUrun satilanUrun)
        {
            _satilanUrunDal.Add(satilanUrun);
        }

        public void SatilanUrunDelete(SatilanUrun satilanUrun)
        {
            _satilanUrunDal.Delete(satilanUrun);
        }

        public void SatilanUrunUpdate(SatilanUrun satilanUrun)
        {
            //
        }
    }
}
