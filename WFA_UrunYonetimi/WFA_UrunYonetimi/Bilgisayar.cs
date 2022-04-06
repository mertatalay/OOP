using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UrunYonetimi
{
    public abstract class Bilgisayar:Urun
    {
        public string EkranKarti { get; set; }
        public string İslemci { get; set; }
        public int RAM { get; set; }
       

        
    }
}
