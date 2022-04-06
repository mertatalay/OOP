using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public static List<Brans> bransListesi = new List<Brans>();
        public static List<Doktor> doktorlistesi = new List<Doktor>();
        Doktor doktor = new Doktor();
        Randevu randevu = new Randevu();
        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans brans = new Brans();
            brans.BransAdi = txtBrans.Text;
            bransListesi.Add(brans);
            cmbBrans.Items.Add(brans);
            txtBrans.Text = "";
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            doktor.DoktorAdi = txtDoktorAd.Text;
            doktor.Brans = cmbBrans.SelectedItem.ToString();
            randevu.DoktorAdi = doktor.DoktorAdi;
            randevu.BransAdi = doktor.Brans;
            doktorlistesi.Add(doktor);
            comboBox1.Items.Add(randevu.BransAdi);
            comboBox2.Items.Add(randevu.DoktorAdi);

            txtDoktorAd.Text = "";
            cmbBrans.SelectedIndex = -1;

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Doktor doktor in doktorlistesi)
            {
                comboBox1.Items.Add(doktor.Brans);
            }
            
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            


            if (dateTimePicker1.Value>DateTime.Now)
            {


                DateTime dt = new DateTime();
                
                dt = dt.AddHours(9.00);
                for (int j = 0; j < 8; j++)
                {
                    dt = dt.AddMinutes(30);
                    Button btn = new Button();
                    btn.Width = 150;
                    btn.Height = 20;
                    btn.Text = dt.ToString();
                    btn.Click += Btn_Click;
                    flowLayoutPanel1.Controls.Add(btn);

                   
                }






















            }
            else
            {
                MessageBox.Show("Geçerli tarih giriniz");
            }
            
          


        }

        private void Btn_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
           btn.Enabled= false;
            if (btn.BackColor.Name=="Red")
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    flowLayoutPanel1.Controls[i].Enabled = false;
                }
                
            }
            
        }
    }
}
