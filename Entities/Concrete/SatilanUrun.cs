using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SatilanUrun : IEntity
    {
        [Key]
        public int SatilanUrunID { get; set; }
        [StringLength(50)]
        public string SatilanUrunAd { get; set; }
        public DateTime SatisTarih { get; set; }
        public int SatisAdet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
