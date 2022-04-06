using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AracListesi
{
    public class Araba
    {

        public string marka { get; set; }
        public string model { get; set; }
        public int uretimyili { get; set; }
        public int saseno { get; set; }
        public int motorgucu { get; set; }
        public string  yakittipi { get; set; }
        public string vitestipi { get; set; }
        public int jantboyut { get; set; }
        public string renk { get; set; }
        public string kasatipi { get; set; }
        public decimal fiyat { get; set; }
        public decimal KDVDahilFiyat 
        { 
            get
            {

                return fiyat * 1.18m;

            }  
        }


    }
}
