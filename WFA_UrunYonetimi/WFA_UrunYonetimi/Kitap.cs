using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    internal abstract class Kitap:Urun
    {
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
       

    }
}
