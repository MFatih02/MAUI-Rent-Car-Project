using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using WebApplication1.Models;
using WebApplication2.Models;

namespace WebApplication1.EF
{
    public class CarContext : DbContext
    {
        public DbSet<AraclarModel> Arac { get; set; }
        public DbSet<Kullanicilar> Kisi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=Test;User Id=Fatih;Password=123456789;TrustServerCertificate=true");
        }
    }
}
