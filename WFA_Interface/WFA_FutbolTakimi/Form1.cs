using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FutbolTakimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Futbolcu> FutbolcuListesi = new List<Futbolcu>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            Futbolcu futbolcu = new Futbolcu();

            futbolcu.Adi = "Mert";
            futbolcu.Soyadi = "Atalay";
            futbolcu.Yas = 34;
            futbolcu.FormaNumarasi = "11";
            futbolcu.Mevki = "forvet";

            Futbolcu futbolcu1 = new Futbolcu();

            futbolcu1.Adi = "A";
            futbolcu1.Soyadi = "BBB";
            futbolcu1.Yas = 32;
            futbolcu1.FormaNumarasi = "10";
            futbolcu1.Mevki = "Orta Saha";

            Futbolcu futbolcu2 = new Futbolcu();

            futbolcu2.Adi = "B";
            futbolcu2.Soyadi = "CC";
            futbolcu2.Yas = 30;
            futbolcu2.FormaNumarasi = "7";
            futbolcu2.Mevki = "Defans";

            FutbolcuListesi.Add(futbolcu1);
            FutbolcuListesi.Add(futbolcu2);
            FutbolcuListesi.Add(futbolcu);

            foreach(Futbolcu futbolcular in FutbolcuListesi)
            {
                listBox1.Items.Add(futbolcular);
            }

            
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                Futbolcu secilifutbolcu=(Futbolcu)listBox1.SelectedItems[0];

                MessageBox.Show(secilifutbolcu.Adi + secilifutbolcu.Soyadi);
            }
        }
    }
}
