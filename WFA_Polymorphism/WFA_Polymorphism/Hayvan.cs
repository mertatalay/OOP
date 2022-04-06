using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    public class Hayvan
    {
        //Özellikler
        public short AyakSayisi { get; set; }
        public bool Ucar { get; set; }

        //Eylem(Metot)

        //polymorphism -- Çok biçimlilik
        //Base class içerisinde tanımlı olan property veya eylemlerin (metot) miras verilen class da farklı davranışlarına polymorphism denir.
        //İsteğe bağlı ezme(override) işlemi olarak da adlandırılmaktadır.
        //virtual -- isteğe bağlı olarak ezilebileceğini temsil eder
        public virtual string sescikar()
        {
            return "Tanımlı hayvan sesi";
        }
        
    }
}
