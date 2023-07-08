using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Xaml;
using Proje.Models;
using Proje.Services;
using System;
using System.Collections.ObjectModel;

namespace Proje.Page;

public partial class AnaSayfa : ContentPage
{
    private readonly ICarService carService;

    public ObservableCollection<AracModelM> anabilgi { get; set; }
		
    public AnaSayfa()
	{
		InitializeComponent();
        anabilgi = new ObservableCollection<AracModelM>();
        carService = new CarService();
        LoadBilgi();
    }

    private async void LoadBilgi()
    {
        var araclar = await carService.GetAracModel();
        anabilgi=new ObservableCollection<AracModelM>(araclar);
        Araçlar.ItemsSource = anabilgi;
        

    }

    
    private async void Basildi(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Proje.Page.Profil());
    }
    private async void Basildi1(object sender, EventArgs e)
    {
        Login girisPage = new Login();
        await Navigation.PushModalAsync(new NavigationPage(girisPage) { BarBackgroundColor = Colors.Transparent, BarTextColor = Colors.White });
    }

    private async void Detaya_Tiklandi(object sender, EventArgs e)
    {
        var buton = (Button)sender;
        var araclar1 = (AracModelM)buton.BindingContext;
        Dictionary<string, Type> AracPages = new Dictionary<string, Type>
{
    { "Clio", typeof(Page.Detaylar.Detay_Clio) },
    { "Megane", typeof(Page.Detaylar.Detay_Megane) },
    { "Sandero", typeof(Page.Detaylar.Detay_Sandero) },
    { "Focus", typeof(Page.Detaylar.Detay_Focus) },
    { "Egea", typeof(Page.Detaylar.Detay_Egea) },
    { "520d", typeof(Page.Detaylar.Detay_520d) },
    { "C180", typeof(Page.Detaylar.Detay_C180) },
    { "A6", typeof(Page.Detaylar.Detay_A6) },
    { "Astra", typeof(Page.Detaylar.Detay_Astra) },
    { "Civic", typeof(Page.Detaylar.Detay_Civic) },
    { "i20", typeof(Page.Detaylar.Detay_Ý20) },
    { "Qashqai", typeof(Page.Detaylar.Detay_Qashqai) },
    { "Giulia", typeof(Page.Detaylar.Detay_Giulia) },
    { "Cruze", typeof(Page.Detaylar.Detay_Cruze) },
    { "4008", typeof(Page.Detaylar.Detay_4008) }
};

        if (AracPages.ContainsKey(araclar1.Model))
        {
            await Navigation.PushAsync((Microsoft.Maui.Controls.Page)Activator.CreateInstance(AracPages[araclar1.Model]));
        }

    }
}