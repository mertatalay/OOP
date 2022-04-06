using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kitap> Kitaplik=new List<Kitap>();
        List<Oyuncak> Oyuncakkutusu=new List<Oyuncak>();
        List<Kulaklik> Kulaklikkutusu = new List<Kulaklik>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Kitap k1=new Kitap();
            k1.KitapAd = "Beyaz diş";
            k1.YazarAd="Jack lONDON";
            k1.Fiyat = 25;
            k1.YayinEvi = "can";

            Kitap k2=new Kitap();
            k2.KitapAd = "1984";
            k2.YazarAd = "George orwell";
            k2.YayinEvi = "can";
            k2.Fiyat = 30;

            Kitaplik.Add(k1);
            Kitaplik.Add(k2);


            Kulaklik kulaklik=new Kulaklik();
            kulaklik.Fiyat = 2000;
            kulaklik.Marka = "Elma";
            kulaklik.Model = "airpods";
            Kulaklikkutusu.Add(kulaklik);


            Oyuncak oyuncak=new Oyuncak();
            oyuncak.Marka = "Action man";
            oyuncak.Model = "Dalgıç";
            oyuncak.Fiyat = 500;


            Oyuncakkutusu.Add(oyuncak);

            foreach (Kitap k in Kitaplik)
            {
                

            }
        }
    }
}
