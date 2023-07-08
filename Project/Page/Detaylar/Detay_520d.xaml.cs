using Proje.Models;
using Proje.Services;
using System.Collections.ObjectModel;

namespace Proje.Page.Detaylar;

public partial class Detay_520d : ContentPage
{
    private readonly ICarService carService;

    public ObservableCollection<AracModelM> anabilgi { get; set; }
   
   
    public Detay_520d()
	{
        InitializeComponent();
        anabilgi = new ObservableCollection<AracModelM>();
        carService = new CarService();
        LoadBilgi();
        
    }
    private async void LoadBilgi()
    {
        var araclar = await carService.GetAracModel();
        anabilgi = new ObservableCollection<AracModelM>(araclar.Where(x => x.Model.Contains("520d")));
        Arac_Detaylari.ItemsSource = anabilgi;
        MarkaBaslik.ItemsSource = anabilgi;
        ModelBaslik.ItemsSource = anabilgi;
        ModelYilBaslik.ItemsSource = anabilgi;
        KilometreBaslik.ItemsSource = anabilgi;
        YakitBaslik.ItemsSource = anabilgi;
        BagajBaslik.ItemsSource = anabilgi;
        SanzimanBaslik.ItemsSource = anabilgi;
        

    }
}