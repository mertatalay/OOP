using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_FutbolTakimi
{
    public   class Futbolcu
    {
        public string Mevki { get; set; }
        public int Yas { get; set; }
        public string FormaNumarasi { get; set; }
     
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public override string ToString()
        {
            return"Adı: "+ Adi+"Soyadı:"+ Soyadi+"Yas:" + Yas+ "Mevki: "+ Mevki+"Forma Numarası:" + FormaNumarasi;
        }




    }
}
