using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs.Model
{
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Kontenjan { get; set; }
        public int AktifKontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
