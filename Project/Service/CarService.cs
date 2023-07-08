using Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proje.Services
{
    internal interface ICarService
    {
        Task<List<AracModelM>> GetAracModel();
        Task<List<KullaniciM>> GetKullanıcılar();
        Task Ekle(KullaniciM kullanıcılarM);
        Task Guncelle(KullaniciM kullanıcılarM);
        Task Sil(Guid kullanıcıId);

        Task<bool> KullaniciAdiVarMi(string kullaniciAdi);

    }
    public class UrlHelper
    {
        public static string BaseAddress =
            DeviceInfo.Platform == DevicePlatform.Android ? "https://10.0.2.2:7249" : "https://localhost:7249";

        public static string ArabalarUrl = $"{BaseAddress}/Arabalar";
        public static string KullanıcıUrl = $"{BaseAddress}/Kullanıcı";

    }
    public class CarService : ICarService
    {

        HttpClient httpClient;
        JsonSerializerOptions jsonSerializerOptions;
        public CarService()
        {
            httpClient = new HttpClient();

            jsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        }

     

        public async Task Ekle(KullaniciM kullanıcılarM)
        {
            var json = JsonSerializer.Serialize(kullanıcılarM);

            JsonContent jsonContent = JsonContent.Create(kullanıcılarM);
            var response = await httpClient.PostAsync(UrlHelper.KullanıcıUrl, jsonContent);
            if (response.IsSuccessStatusCode)
            {

            }
        }
        public async Task Guncelle(KullaniciM kullanıcılarM)
        {
            var jsonContent = JsonContent.Create(kullanıcılarM);
            var response = await httpClient.PostAsync(UrlHelper.KullanıcıUrl + "/guncelle", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                
            }
        }
        public async Task<List<AracModelM>> GetAracModel()
        {
            var sonuc = await httpClient.GetFromJsonAsync<List<AracModelM>>(UrlHelper.ArabalarUrl);

            return sonuc;
           
        }
        public async Task<List<KullaniciM>> GetKullanıcılar()
        {
            var kullanıcıGetir = await httpClient.GetFromJsonAsync<List<KullaniciM>>(UrlHelper.KullanıcıUrl);
            return kullanıcıGetir;
        }

        

        public async Task Sil(Guid kullanıcıId)
        {

            var url = UrlHelper.KullanıcıUrl + $"/{kullanıcıId}";
            await httpClient.DeleteAsync(url);
        }

        public async Task<bool> KullaniciAdiVarMi(string kullaniciAdi)
        {
            var kullanıcılar = await httpClient.GetFromJsonAsync<List<KullaniciM>>(UrlHelper.KullanıcıUrl);
            return kullanıcılar.Any(k => k.KullaniciAdi == kullaniciAdi);
        }

    }
}
