using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    internal class Urun
    {

        public string Marka { get; set; }
        public string Beden { get; set; }
        public short Numara { get; set; }
        public decimal Fiyat { get; set; }
        public string Urunadi { get; set; }
        public string Kategori { get; set; }
        public int Tarih { get; set; }
        public decimal KDVDahilFiyat 
        {
            get
            {
                return Fiyat *1.18m;
            }
        }


    }
}
