using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetList();
        void UrunAdd(Urun urun);
        Urun GetByID(int id);
        void UrunUpdate(Urun urun);
        void UrunDelete(Urun urun);
    }
}
