using Proje.Models;
using Proje.Services;

namespace Proje.Page;

public partial class ParolaDegistir : ContentPage
{
    private readonly ICarService carService;

    public ParolaDegistir()
    {
        InitializeComponent();

        carService = new CarService();
    }
   
    private async void Degistir(object sender, EventArgs e)
    {
        string ad = Login.ad;
        string eskisifre = Login.parola;
        string sifre = SifreEntry.Text;

        
        if(eskisifre == sifre)
        {
            await DisplayAlert("Hata!!!", "Yeni þifre eskisi ile ayný olamaz.", "Tamam");
            return;
        }
        if (sifre.Length < 5)
        {
            await DisplayAlert("Hata", "Þifre en az 5 karakter olmalýdýr.", "Tamam");
            return;
        }
        List<KullaniciM> kullanýcýlar = await carService.GetKullanýcýlar();
        KullaniciM kullanici = kullanýcýlar.FirstOrDefault(k => k.Parola == eskisifre && k.KullaniciAdi == ad);

        if (kullanici != null)
        {
            kullanici.Parola = sifre; 

            await carService.Guncelle(kullanici);
            await DisplayAlert("Baþarýlý", "Þifre deðiþtirme iþlemi baþarýyla tamamlandý.", "Tamam");
            Login mainPage = new Login();
            await Navigation.PushModalAsync(new NavigationPage(mainPage) { BarBackgroundColor = Colors.Transparent, BarTextColor = Colors.White });
        }
    


    }

    private async void geriButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}