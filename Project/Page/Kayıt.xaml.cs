using Proje.Models;
using Proje.Services;

namespace Proje.Page;

public partial class Kayıt : ContentPage
{
    private readonly ICarService service_;


    public Kayıt()
    {
        InitializeComponent();
        service_ = new CarService();


    }

    private async void GirisYap(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Proje.Login());
    }


    private async void Kayit(object sender, EventArgs e)
    {
        string kullaniciAdi = KullaniciAdiEntry.Text;
        string sifre = SifreEntry.Text;
        string cinsiyet = genderPicker.SelectedItem?.ToString();
        string telefon = TelefonEntry.Text;



        DateTime selectedDate = datePicker.Date;

        if (await service_.KullaniciAdiVarMi(kullaniciAdi))
        {
            await DisplayAlert("Hata", "Aynı Kullanıcı Adında Bir Kullanıcı Zaten Mevcut", "Tamam");
            return;
        }

        if (kullaniciAdi.Length < 4)
        {
            await DisplayAlert("Hata", "Kullanıcı adı en az 4 karakter olmalıdır.", "Tamam");
            return;
        }

        if (sifre.Length < 5)
        {
            await DisplayAlert("Hata", "Şifre en az 4 karakter olmalıdır.", "Tamam");
            return;
        }

        KullaniciM yeniKullanici = new KullaniciM()
        {
            Id = Guid.NewGuid(),
            KullaniciAdi = kullaniciAdi,
            Parola = sifre,
            Cinsiyet = cinsiyet,
            DoğumTarihi = selectedDate,
            Telefon = telefon,
        };

        await service_.Ekle(yeniKullanici);

        await Navigation.PushAsync(new Login());

        
    }


}