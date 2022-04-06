using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Ekstra
    {
        public string EkstarAdi { get; set; }
        public decimal ExtraFiyati { get; set; }
        public override string ToString()
        {
            return "Ekstra Adı: " + EkstarAdi + " " +"Ekstra Fiyatı: " + ExtraFiyati;
        }
    }
}
