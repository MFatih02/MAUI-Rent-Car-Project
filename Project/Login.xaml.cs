using Proje.Models;
using Proje.Page;
using Proje.Services;
using System.Reflection.Metadata;

namespace Proje;

public partial class Login : ContentPage
{
    private readonly ICarService carService;
    public static string ad { get; set; }
    public static string parola { get; set; }


    public Login()
    {
        InitializeComponent();
        carService = new CarService();

    }


    private async void GirisYapButton_Clicked(object sender, EventArgs e)
    {
         ad = KullaniciAdiEntry.Text;
         parola = SifreEntry.Text;





         
         List<KullaniciM> kullanýcýlar = await carService.GetKullanýcýlar();

         
         KullaniciM kullanici = kullanýcýlar.FirstOrDefault(k => k.KullaniciAdi == ad && k.Parola == parola);

         if (kullanici != null)
         {
         
         
             await Navigation.PushAsync(new Proje.Page.AnaSayfa());

         
         }
         else
         {
         
             await DisplayAlert("Hata", "Geçersiz kullanýcý adý veya þifre", "Tamam");
         }
        
        
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Proje.Page.Kayýt());
    }


}