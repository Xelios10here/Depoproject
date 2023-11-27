using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urun : IEntity
    {
        [Key]
        public int UrunID { get; set; }
        [StringLength(50)]
        public string UrunAd { get; set; }
        public short Stok { get; set; }
      //  public bool Durum { get; set; }
    }
}
