using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    internal class Kedi:Hayvan
    {
        public bool Nankormu { get; set; }

        public override string sescikar()
        {
            return "Miyavv";
        }
    }
}
