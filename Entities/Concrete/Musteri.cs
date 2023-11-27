using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Musteri : IEntity
    {
        [Key]
        public int MusteriID { get; set; }
        [StringLength(50)]
        public string MusteriAd { get; set; }
        [StringLength(50)]
        public string MusteriSoyad { get; set; }
        [StringLength(50)]
        public string MusteriMail { get; set; }
        [StringLength(50)]
        public string MusteriFirma { get; set; }
    }
}
