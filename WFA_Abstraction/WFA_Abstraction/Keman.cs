﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Abstraction
{
    public class Keman : MuzikAleti
    {
        public override string Cal()
        {
            return "Keman çalınıyor";
        }

        public override string ToString()
        {
            return "Keman " + Marka;
        }
    }
}
