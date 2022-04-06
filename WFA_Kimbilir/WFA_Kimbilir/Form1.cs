using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kimbilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        string[] isimler = { "EDEBALİ MERT ATALAY", "AZAD MAJIDLI", "SILA ŞİRİN ", "UMUT YILBAŞ ", "SARUHAN MERT DEMİRAY", "ONUR DOĞRU", "Emre Bektaşoğlu ", "ENES SERENLİ ", "KAAN ÜNAL ", "BAHADIR ARDA ", "MERT ÇINAR", "BURAK UYSAL ", "AHMET CANER TATLI ", "TUBA KARADUT BUĞDAY", "MAHMURE OKAN", "ARYA KAPIKIRAN", "BERK BASAT" };

        string[] Konular = { "Polymorphism" , "inheritance", "Abstraction", "interface", "enum", "constructor", "class", "static", "encapsulation" };
        string[] Github = { "onurdogru34- Onur Doğru", "umutyilbas - Umut Yılbaş ", "enessrnli - Enes Serenli ", "aryathequeen - Arya Kapıkıran", "mahmureokann - Mahmure Okan", "uysal6 - Berk Uysal", "berkbasat - Berk Basat", "silasirin - Sıla Şirin", "CanerTatli - Caner Tatlı", "mertatalay - Mert Atalay", "furkici - Furkan" };
        Random rnd = new Random();
        
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)


        {
            
            

           
            for(int i = 0; i < isimler.Length; i++)
            {
                
                listBox1.Items.Add(isimler[i]);
            }
            for(int j = 0; j < Konular.Length; j++)
            {
                listBox2.Items.Add(Konular[j]);
            }
            for(int k = 0; k < Github.Length; k++)
            {
                listBox4.Items.Add(Github[k]);
            }
            
            
            




















        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            

            int sec=rnd.Next(0,isimler.Length);
            int konusec=rnd.Next(0,Konular.Length);

            list.Add(sec.ToString()+konusec.ToString());
            
            DialogResult dr = MessageBox.Show(isimler[sec] +" "+ Konular[konusec], "seçildiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if(dr == DialogResult.Yes)
            {

                listBox3.Items.Add(isimler[sec]+"  "+Konular[konusec]);
                listBox1.Items.Remove(isimler[sec].ToString());
            }
            else
            {
                
            }
        }

       
    }
}
