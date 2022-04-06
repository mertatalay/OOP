using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Static
{
    internal class Personel
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime IseGirisTarihi { get; set; }

        public static int PersonelSayisi { get; set; }


        public  Personel()
        {
            PersonelSayisi++;
        }

    }




    
}
