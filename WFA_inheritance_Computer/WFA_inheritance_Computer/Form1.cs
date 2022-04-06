using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_inheritance_Computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun>urunler=new List<Urun>();


       
        private void Form1_Load(object sender, EventArgs e)
        {
           EkranKarti ekranKarti=   new EkranKarti();
            AnaKart anaKart= new AnaKart();
            Islemci islemci= new Islemci();

            ekranKarti.Marka = "İntel";
            ekranKarti.Fiyat = 2500;
            anaKart.Marka = "Gigabyte";
            anaKart.Fiyat = 1000;
            islemci.Marka = "İntel";
            islemci.Fiyat = 5000;
           Bilgisayar bilgisayar= new Bilgisayar();
            bilgisayar.Anakart = anaKart;
            bilgisayar.Islemci = islemci;
            bilgisayar.EkranKarti = ekranKarti;
            bilgisayar.Monitor = "Samsung";
            bilgisayar.RAM = 8;
            bilgisayar.Fiyat = 7000;
            bilgisayar.Aktif = true;

            urunler.Add(ekranKarti);
            urunler.Add(anaKart);
            urunler.Add(islemci);
            urunler.Add(bilgisayar);


           foreach(Urun urun in urunler)
            {
                if(urun is AnaKart)
                {
                    AnaKart anakart = (AnaKart)urun;
                    //string format = $"{anakart.Marka} {anakart.Fiyat}";
                    lstanakart.Items.Add(anakart);
                }
                else if (urun is EkranKarti)
                {
                    EkranKarti ekranKarti1 = (EkranKarti)urun;
                    //string format = $"{ekranKarti.Marka} {ekranKarti.Fiyat}";
                    lstekrankarti.Items.Add(ekranKarti1);
                }
               else  if (urun is Islemci)
                {
                    Islemci islemci1 = (Islemci)urun;
                    //string format = $"{islemci.Marka} {islemci.Fiyat}";
                    lstislemci.Items.Add(islemci1);
                }
            }

            



            
            


           



            

        }
        decimal Toplamtutar = 0;
        private void lstanakart_DoubleClick(object sender, EventArgs e)
        {
            AnaKart secilianakart= (AnaKart)lstanakart.SelectedItem;
            listBox1.Items.Add(secilianakart);
            
            label1.Text = secilianakart.Fiyat.ToString();
            Toplamtutar += secilianakart.Fiyat;
            label1.Text=Toplamtutar.ToString();

            
        }

        private void lstekrankarti_DoubleClick(object sender, EventArgs e)
        {
            EkranKarti seciliekranKarti= (EkranKarti)lstekrankarti.SelectedItem;
            listBox1.Items.Add(seciliekranKarti);
            label1.Text = seciliekranKarti.Fiyat.ToString();    
            Toplamtutar += seciliekranKarti.Fiyat;
            label1.Text=Toplamtutar.ToString() ;
            

        }
    }
}
