using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Models
{

    public class Rootobject
    {
        public AracModelM[] Property1 { get; set; }
    }

    public class AracModelM
    {
        public Guid Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYil { get; set; }
        public double Kilometre { get; set; }
        public string YakitTürü { get; set; }
        public double BagajHacmi { get; set; }
        public string Şanzıman { get; set; }
        public string FotoUrl { get; set; }

    }

}
