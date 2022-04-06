﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitaplik = new List<Kitap>();
        List<Oyuncak> oyuncakKutusu = new List<Oyuncak>();
        List<Kulaklik> kulaklikKutusu = new List<Kulaklik>();

        private void Form1_Load(object sender, EventArgs e)
        {

            //Kitaplar
            Kitap k1 = new Kitap();
            k1.KitapAd = "Beyaz Diş";
            k1.YazarAd = "Jack London";
            k1.Fiyat = 25;
            k1.YayinEvi = "Can";

            Kitap k2 = new Kitap();
            k2.KitapAd = "1984";
            k2.YazarAd = "George Orwell";
            k2.YayinEvi = "Can";
            k2.Fiyat = 30;

            kitaplik.Add(k1);
            kitaplik.Add(k2);

            //Kulaklık
            Kulaklik kulaklik = new Kulaklik();
            kulaklik.Fiyat = 2000;
            kulaklik.Marka = "Elma";
            kulaklik.Model = "airpods";

            kulaklikKutusu.Add(kulaklik);

            //Oyuncak
            Oyuncak oyuncak = new Oyuncak();
            oyuncak.Marka = "Action man";
            oyuncak.Model = "Dalgıç";
            oyuncak.Fiyat = 500;

            oyuncakKutusu.Add(oyuncak);


            foreach(Kitap kitap in kitaplik)
            {
                MessageBox.Show(kitap.KitapAd + " " + kitap.Fiyat);
            }

            foreach (Kulaklik k in kulaklikKutusu)
            {
                MessageBox.Show(k.Marka + " " + k.Fiyat);
            }

            foreach (Oyuncak o in oyuncakKutusu)
            {
                MessageBox.Show(o.Marka + " " + o.Fiyat);
            }

        }
    }
}
