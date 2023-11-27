using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISatilanUrunService
    {
        List<SatilanUrun> GetList();
        void SatilanUrunAdd(SatilanUrun satilanUrun );
        SatilanUrun GetByID(int id);
        void SatilanUrunUpdate(SatilanUrun satilanUrun);
        void SatilanUrunDelete(SatilanUrun satilanUrun);
    }
}
