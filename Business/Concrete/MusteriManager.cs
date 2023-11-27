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
    public class MusteriManager : IMusteriService
    {


        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        public Musteri GetByID(int id)
        {
            return _musteriDal.Get(x => x.MusteriID == id); ;//Buraya bakılacak
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
            _musteriDal.Update(musteri);//
        }
    }
}
