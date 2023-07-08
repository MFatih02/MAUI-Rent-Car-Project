using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WebApplication1.EF;
using WebApplication1.Models;
using WebApplication2.Models;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/Arabalar", () =>
            {
                CarContext carContext = new CarContext();
                return carContext.Arac.ToList();
            });

            app.MapGet("/Kullanýcý", () =>
            {
                CarContext carContext = new CarContext();
                return carContext.Kisi.ToList();
            });

            app.MapPost("/Kullanýcý", (Kullanicilar kullanicilar) =>
            {
                CarContext context = new CarContext();
                context.Kisi.Add(kullanicilar);
                context.SaveChanges();
            });

            app.MapPost("/Kullanýcý/guncelle", (Kullanicilar kullanicilar) =>
            {
                CarContext context = new CarContext();
                var guncellenecek = context.Kisi.Find(kullanicilar.Id);
                guncellenecek.Parola = kullanicilar.Parola;
                context.SaveChanges();
            });



            app.MapDelete("/Kullanýcý/{id}", (string id) =>
            {
                CarContext context = new CarContext();
                var silinecek = context.Kisi.FirstOrDefault(x => x.Id == Guid.Parse(id));
                if (silinecek != null)
                {
                    context.Kisi.Remove(silinecek);
                    context.SaveChanges();
                }
            });
            
            


            app.Run();
        }
    }
}