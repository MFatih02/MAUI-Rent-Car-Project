namespace WebApplication2.Models
{
    public class Kullanicilar
    {
        public Guid Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }

        
    }
}
