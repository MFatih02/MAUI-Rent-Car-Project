using Proje.Models;
using Proje.Services;
using System.Collections.ObjectModel;

namespace Proje.Page.Detaylar;

public partial class Detay_4008 : ContentPage
{
    private readonly ICarService carService;

    public ObservableCollection<AracModelM> anabilgi { get; set; }
    
   
    public Detay_4008()
	{
        InitializeComponent();
        anabilgi = new ObservableCollection<AracModelM>();
        carService = new CarService();
        LoadBilgi();
    }
    private async void LoadBilgi()
    {
        var araclar = await carService.GetAracModel();
        anabilgi = new ObservableCollection<AracModelM>(araclar.Where(x => x.Model.Contains("4008")));
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