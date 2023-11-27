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
            using (var dbContext = new DbsistembirContext())//işlem yaparken new kullanıyor
            {
                // Gönderdiğimiz ürün ID'sine sahip olan ürünü veritabanından bul
                var urunToUpdate = dbContext.Uruns.SingleOrDefault(p => p.UrunID == urun.UrunID);

                if (urunToUpdate != null)
                {
                    // Ürün bilgilerini güncelle
                    urunToUpdate.UrunAd = urun.UrunAd;
                    urunToUpdate.UrunID = urun.UrunID;
                    urunToUpdate.Stok = urun.Stok;



                    // Değişiklikleri veritabanına kaydet
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
