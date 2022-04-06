using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Polymorphism
{
    internal class At : Hayvan
    {
        public bool Yarisati { get; set; }

        public override string sescikar()
        {
            return "ıhhh";
        }
    }
}
