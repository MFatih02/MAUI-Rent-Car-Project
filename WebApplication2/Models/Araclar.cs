using WebApplication1.EF;

namespace WebApplication1.Models
{
    public class Araclar
    {
        public void Cars()
        {
            CarContext context = new CarContext();
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Alfa Romeo",
                Model = "Giulia",
                ModelYil = "2020",
                BagajHacmi = 350,
                Kilometre = 59657,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "alfaromeo_giulia_2020.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Audi",
                Model = "A6",
                ModelYil = "2023",
                BagajHacmi = 565,
                Kilometre = 27356,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "audi_a6_2023.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "BMW",
                Model = "520d",
                ModelYil = "2014",
                BagajHacmi = 520,
                Kilometre = 157687,
                YakitTürü = "Dizel",
                Şanzıman = "Otomatik",
                FotoUrl = "bmw_520d_2014.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Chevrolet",
                Model = "Cruze",
                ModelYil = "2012",
                BagajHacmi = 450,
                Kilometre = 187157,
                YakitTürü = "Benzin",
                Şanzıman = "Manuel",
                FotoUrl = "chevrolet_cruze_2012.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Dacia",
                Model = "Sandero",
                ModelYil = "2018",
                BagajHacmi = 320,
                Kilometre = 69851,
                YakitTürü = "Dizel",
                Şanzıman = "Manuel",
                FotoUrl = "dacia_sandero_2018.jpeg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Fiat",
                Model = "Egea",
                ModelYil = "2021",
                BagajHacmi = 520,
                Kilometre = 97253,
                YakitTürü = "Benzin",
                Şanzıman = "Manuel",
                FotoUrl = "fiat_egea_2021.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Ford",
                Model = "Focus",
                ModelYil = "2019",
                BagajHacmi = 341,
                Kilometre = 110365,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "ford_focus_2019.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Honda",
                Model = "Civic",
                ModelYil = "2022",
                BagajHacmi = 512,
                Kilometre = 98523,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "honda_civic_2022.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Hyundai",
                Model = "i20",
                ModelYil = "2021",
                BagajHacmi = 352,
                Kilometre = 57523,
                YakitTürü = "Benzin",
                Şanzıman = "Manuel",
                FotoUrl = "hyundai_i20_2021.jpeg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Mercedes",
                Model = "C180",
                ModelYil = "2018",
                BagajHacmi = 480,
                Kilometre = 69512,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "mercedes_c180_2018.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Nissan",
                Model = "Qashqai",
                ModelYil = "2020",
                BagajHacmi = 401,
                Kilometre = 47138,
                YakitTürü = "Dizel",
                Şanzıman = "Otomatik",
                FotoUrl = "nissan_qashqai_2020.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Opel",
                Model = "Astra",
                ModelYil = "2023",
                BagajHacmi = 422,
                Kilometre = 12578,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "opel_astra_2023.png"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Peugeot",
                Model = "4008",
                ModelYil = "2023",
                BagajHacmi = 416,
                Kilometre = 10578,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "peugeot_4008_2023.jpg"

            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Renault",
                Model = "Clio",
                ModelYil = "2020",
                BagajHacmi = 391,
                Kilometre = 69523,
                YakitTürü = "Dizel",
                Şanzıman = "Otomatik",
                FotoUrl = "renault_clio_2020.jpg"
            });
            context.Arac.Add(new Models.AraclarModel
            {
                Id = Guid.NewGuid(),
                Marka = "Renault",
                Model = "Megane",
                ModelYil = "2020",
                BagajHacmi = 503,
                Kilometre = 156324,
                YakitTürü = "Benzin",
                Şanzıman = "Otomatik",
                FotoUrl = "renault_megane_2020.jpg"

            });


            context.SaveChanges();
        }
    }
}
