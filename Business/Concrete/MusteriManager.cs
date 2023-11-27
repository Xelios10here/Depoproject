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
    public class MusteriManager : IMusteriService
    {


        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        public Musteri GetByID(int id)
        {
            return _musteriDal.Get(x => x.MusteriID == id); //Buraya bakılacak
        }

        public List<Musteri> GetList()
        {
            return _musteriDal.GetAll();
        }

        public void MusteriAdd(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }
        public void MusteriDelete(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
        }



        public void MusteriUpdate(Musteri musteri)
        {
            using (var dbContext = new DbsistembirContext())
            {
                // Gönderdiğimiz ürün ID'sine sahip olan ürünü veritabanından bul
                var musteriToUpdate = dbContext.Musteris.SingleOrDefault(p => p.MusteriID == musteri.MusteriID);

                if (musteriToUpdate != null)
                {
                    // Ürün bilgilerini güncelle
                    musteriToUpdate.MusteriAd = musteri.MusteriAd;
                    musteriToUpdate.MusteriID = musteri.MusteriID;
                    musteriToUpdate.MusteriSoyad = musteri.MusteriSoyad;
                    musteriToUpdate.MusteriMail = musteri.MusteriMail;
                    musteriToUpdate.MusteriFirma = musteri.MusteriFirma;

                    // Değişiklikleri veritabanına kaydet
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
