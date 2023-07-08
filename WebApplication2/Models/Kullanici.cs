using WebApplication1.EF;

namespace WebApplication2.Models
{
    public class Kullanici
    {
        public void Kisi()
        {
            CarContext context = new CarContext();
            context.Kisi.Add(new Models.Kullanicilar
            {
                Id = Guid.NewGuid(),
                KullaniciAdi ="Admin",
                Parola ="admin",
                Telefon = "05555555555",
                Cinsiyet = "Erkek",
            });
            context.SaveChanges();
        }
    }
}
