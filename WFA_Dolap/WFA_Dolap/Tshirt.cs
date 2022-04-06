using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Dolap
{
    internal class Tshirt : Urun
    {
        public override string ToString()
        {
            return $"Marka: {Marka} Beden: {Beden} Fiyat: {Fiyat}";
        }
    }
}
