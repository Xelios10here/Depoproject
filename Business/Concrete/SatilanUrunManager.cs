
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
            return _satilanUrunDal.Get(x => x.SatilanUrunID == id);
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
            using (var dbContext = new DbsistembirContext())//işlem yaparken new kullanıyor
            {
                // Gönderdiğimiz ürün ID'sine sahip olan ürünü veritabanından bul
                var satilanUrunToUpdate = dbContext.SatilanUruns.SingleOrDefault(p => p.SatilanUrunID == satilanUrun.SatilanUrunID);

                if (satilanUrunToUpdate != null)
                {
                    // Ürün bilgilerini güncelle
                    satilanUrunToUpdate.SatilanUrunAd = satilanUrun.SatilanUrunAd;
                    satilanUrunToUpdate.SatilanUrunID = satilanUrun.SatilanUrunID;
                    satilanUrunToUpdate.SatisTarih = satilanUrun.SatisTarih;
                    satilanUrunToUpdate.SatisAdet = satilanUrun.SatisAdet;
                    satilanUrunToUpdate.Fiyat = satilanUrun.Fiyat;


                    // Değişiklikleri veritabanına kaydet
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
