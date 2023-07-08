using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Models
{

    public class Rootobject1
    {
        public KullaniciM[] Property1 { get; set; }
    }

    public class KullaniciM
    {
        public Guid Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string Telefon { get; set; }
        public DateTime DoğumTarihi { get; set; }
        public string Cinsiyet { get; set; }
    }

}
