using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_inheritance_Computer
{
    internal class Bilgisayar:Urun
    {

        public Islemci Islemci { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public string Monitor { get; set; }
        public int RAM { get; set; }
        public AnaKart Anakart { get; set; }
        

    }
}
