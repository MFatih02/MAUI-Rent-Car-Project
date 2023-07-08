using Proje.Models;
using Proje.Services;

namespace Proje.Page;

public partial class Profil : ContentPage
{
    private readonly ICarService carService;
    public Profil()
    {
        InitializeComponent();
        carService = new CarService();
        string ad = Login.ad;
        string sifre = Login.parola;
        kullaniciAdi.Text = ad;
        Sifre.Text = sifre;
        LoadBilgi();
    }
    private async void LoadBilgi()
    {
        List<KullaniciM> kullanicis = await carService.GetKullanıcılar();        
        KullaniciM kullanici = kullanicis.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi.Text && k.Parola == Sifre.Text);

        if (kullanici != null)
        {            
            string dogum = kullanici.DoğumTarihi.ToString("dd/MM/yyyy");
            string cins = kullanici.Cinsiyet;            
            dogumTarihi.Text = dogum;
            cinsiyet.Text = cins;
          
        }

    }
    private async void ParolaDegistir(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Proje.Page.ParolaDegistir());

    }
    private async void HesapSil(object sender, EventArgs e)
    {
        List<KullaniciM> kullanicis = await carService.GetKullanıcılar();

        KullaniciM kullanici = kullanicis.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi.Text && k.Parola == Sifre.Text);

        if (kullanici != null)
        {
            bool confirmed = await DisplayAlert("Onay", "Hesabınızı silmek istediğinize emin misiniz?", "Evet", "Hayır");

            if (confirmed)
            {
                await carService.Sil(kullanici.Id);
                Login mainPage = new Login();
                await Navigation.PushModalAsync(new NavigationPage(mainPage) { BarBackgroundColor = Colors.Transparent, BarTextColor = Colors.White });
            }
        }       
    }

    private async void geriButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}