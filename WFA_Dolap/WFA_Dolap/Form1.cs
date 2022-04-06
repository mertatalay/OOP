using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunler = new List<Urun>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Pantolon pantolon = new Pantolon();
            pantolon.Kategori = "Pantolon";
            pantolon.Marka = "Mavi";
            pantolon.Beden = "32";
            pantolon.Fiyat = 250;
            
            Pantolon pantolon1 = new Pantolon();
            pantolon.Kategori = "Pantolon";
            pantolon1.Marka = "Levis";
            pantolon1.Beden = "36";
            pantolon1.Fiyat = 500;
            Pantolon pantolon2 = new Pantolon();
            pantolon.Kategori = "Pantolon";
            pantolon2.Marka = "Koton";
            pantolon2.Beden = "34";
            pantolon2.Fiyat = 150;
            Tshirt tshirt = new Tshirt();
            tshirt.Kategori = "Tshirt";
            tshirt.Marka = "Polo";
            tshirt.Beden = "S";
            tshirt.Fiyat = 125;
            Tshirt tshirt1 = new Tshirt();
            tshirt.Kategori = "Tshirt";
            tshirt1.Marka = "Mavi";
            tshirt1.Beden = "M";
            tshirt1.Fiyat = 200;
            Tshirt tshirt2 = new Tshirt();
            tshirt.Kategori = "Tshirt";
            tshirt2.Marka = "Jack";
            tshirt2.Beden = "L";
            tshirt2.Fiyat = 300;
            Ayakkabi ayakkabi = new Ayakkabi();
            ayakkabi.Kategori = "Ayakkabı";
            ayakkabi.Marka = "Kemal Tanca";
            ayakkabi.Numara = 42;
            ayakkabi.Fiyat = 500;
            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi.Kategori = "Ayakkabı";
            ayakkabi1.Marka = "Adidas";
            ayakkabi1.Numara = 43;
            ayakkabi1.Fiyat = 700;
            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi.Kategori = "Ayakkabı";
            ayakkabi2.Marka = "Nike";
            ayakkabi2.Numara = 40;
            ayakkabi2.Fiyat = 1000;
            Mont mont=new Mont();
            mont.Urunadi = "Mont";
            mont.Kategori = "Mont";
            mont.Marka = "Colombia";
            mont.Beden = "M";
            mont.Fiyat = 3000;
            Mont mont1 = new Mont();
            mont.Urunadi = "Mont";
            mont.Kategori = "Mont";
            mont1.Marka = "NorthFace";
            mont1.Beden = "L";
            mont1.Fiyat = 3500;
            Mont mont2 = new Mont();
            mont.Urunadi = "Mont";
            mont.Kategori = "Mont";
            mont2.Marka = "Koton";
            mont2.Beden = "M";
            mont2.Fiyat = 350;

            urunler.Add(mont);
            urunler.Add(mont1);
            urunler.Add(mont2);
            urunler.Add(ayakkabi);
            urunler.Add(ayakkabi1);
            urunler.Add(ayakkabi2);
            urunler.Add(tshirt);
            urunler.Add(tshirt1);
            urunler.Add(tshirt2);
            urunler.Add(pantolon);
            urunler.Add(pantolon1);
            urunler.Add(pantolon2);


            foreach(Urun urun in urunler)
            {
                if(urun is Mont)
                {
                    Mont montlar = (Mont)urun;
                    lstMont.Items.Add(montlar);
                    
                }
                else if (urun is Ayakkabi)
                {
                    Ayakkabi ayakkabilar = (Ayakkabi)urun;
                    lstAyakkabi.Items.Add(ayakkabilar);

                }
                else if (urun is Pantolon)
                {
                    Pantolon pantolonlar = (Pantolon)urun;
                    lstPantolon.Items.Add(pantolonlar);

                }
                else if (urun is Tshirt)
                {
                    Tshirt tshirtler = (Tshirt)urun;
                    lstTshirt.Items.Add(tshirtler);

                }
            }





        }
        decimal ToplamFiyat = 0;
        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Ayakkabi seciliayakkabi = (Ayakkabi)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(seciliayakkabi);
            lblToplamTutar.Text=seciliayakkabi.KDVDahilFiyat.ToString();
            ToplamFiyat += seciliayakkabi.KDVDahilFiyat;
            lblToplamTutar.Text = ToplamFiyat.ToString();
        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            Tshirt secilitshirt = (Tshirt)lstTshirt.SelectedItem;
            lstSepet.Items.Add(secilitshirt);
            lblToplamTutar.Text = secilitshirt.KDVDahilFiyat.ToString();
            ToplamFiyat += secilitshirt.KDVDahilFiyat;
            lblToplamTutar.Text = ToplamFiyat.ToString();
        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {
            Mont secilimont = (Mont)lstMont.SelectedItem;
            lstSepet.Items.Add(secilimont);
            lblToplamTutar.Text = secilimont.KDVDahilFiyat.ToString();
            ToplamFiyat += secilimont.KDVDahilFiyat;
            lblToplamTutar.Text = ToplamFiyat.ToString();
        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Pantolon secilipantolon = (Pantolon)lstPantolon.SelectedItem;
            lstSepet.Items.Add(secilipantolon);
            lblToplamTutar.Text = secilipantolon.KDVDahilFiyat.ToString();
            ToplamFiyat += secilipantolon.KDVDahilFiyat;
            lblToplamTutar.Text = ToplamFiyat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
