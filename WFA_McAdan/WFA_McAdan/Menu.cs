﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McAdan
{
    public class Menu
    {

        public string MenuAdi { get; set; }
        public decimal MenuFiyat { get; set; }

        public override string ToString()
        {
            return MenuAdi + " " + MenuFiyat;
        }

    }
}
