using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetList();
        void MusteriAdd(Musteri musteri);
        void MusteriDelete(Musteri musteri);
        void MusteriUpdate(Musteri musteri);
        Musteri GetByID(int id);
    }
}
