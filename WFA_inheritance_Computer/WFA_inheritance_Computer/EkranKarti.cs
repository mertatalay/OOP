using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_inheritance_Computer
{
    internal class EkranKarti:Urun
    {
        public string Marka { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Fiyat}";
        }
    }
}
