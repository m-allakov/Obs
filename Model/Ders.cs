using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs.Model
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersKod { get; set; }
        public string DersAd { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
