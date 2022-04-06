using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    internal class Kopek:Hayvan
    {
        public bool Sadikmi { get; set; }

        public override string sescikar()
        {
            return "Havhavaha";
        }
    }
}
