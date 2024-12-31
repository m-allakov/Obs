using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs.Model
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }

    }
}
