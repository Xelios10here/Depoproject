using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {

        [Key]
        public int AdminID { get; set; }
        [StringLength(10)]
        public string KullaniciAd { get; set; }
        [StringLength(10)]
        public string Sifre { get; set; }
        [StringLength(5)]
        public string Yetki { get; set; }
    }
}
