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
    public class UrunManager : IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public Urun GetByID(int id)
        {
           return _urunDal.Get(p => p.UrunID == id);
        }

        public List<Urun> GetList()
        {
            return _urunDal.GetAll();
        }

        public void UrunAdd(Urun urun)
        {
            _urunDal.Add(urun);
        }

        public void UrunDelete(Urun urun)
        {
            _urunDal.Delete(urun);
        }

        public void UrunUpdate(Urun urun)
        {
            throw new NotImplementedException();//identity de bak ***
        }
    }
}
