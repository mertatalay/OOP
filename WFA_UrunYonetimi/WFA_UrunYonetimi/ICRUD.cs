using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public interface ICRUD
    {
        string ekleme();
        string guncelleme();
        string silme();
        string listeleme();



    }
}
