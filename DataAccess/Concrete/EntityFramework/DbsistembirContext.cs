using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DbsistembirContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I1RPG82;Database=Dbsistemiki;TrustServerCertificate=True; Encrypt=false;Integrated Security=True;");



        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<SatilanUrun>SatilanUruns { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}
