using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba araba = new Araba();
        private void btnekle_Click(object sender, EventArgs e)
        {

            try
            {
                araba.marka = txtmarka.Text;
                araba.model = txtmodel.Text;
                araba.uretimyili = Convert.ToInt32(txturtyil.Text);
                araba.saseno = Convert.ToInt32(txtsase.Text);
                araba.motorgucu = Convert.ToInt32(txtmotor.Text);
                araba.yakittipi = cmbyakit.Text;
                araba.vitestipi = cmbvites.Text;
                araba.jantboyut = Convert.ToInt32(txtjant.Text);
                araba.renk = txtrenk.Text;
                araba.kasatipi = cmbkasa.Text;
                araba.fiyat = nudfiyat.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            ListViewItem lvi=new ListViewItem();
            lvi.Text=araba.marka;
            lvi.SubItems.Add(araba.model);
            lvi.SubItems.Add(araba.uretimyili.ToString());
            lvi.SubItems.Add(araba.saseno.ToString());
            lvi.SubItems.Add(araba.motorgucu.ToString());
            lvi.SubItems.Add(araba.yakittipi);
            lvi.SubItems.Add(araba.vitestipi);
            lvi.SubItems.Add(araba.jantboyut.ToString());
            lvi.SubItems.Add(araba.renk);
            lvi.SubItems.Add(araba.kasatipi);
            lvi.SubItems.Add(araba.fiyat.ToString("C2"));
            lvi.SubItems.Add(araba.KDVDahilFiyat.ToString("C2"));

            listView1.Items.Add(lvi);
           

           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbkasa.Items.Add("Sedan");
            cmbkasa.Items.Add("Hatchback");

            cmbvites.Items.Add("otomatik");
            cmbvites.Items.Add("Manuel");

            cmbyakit.Items.Add("Dizel");
            cmbyakit.Items.Add("Benzin");
        }
    }
}
