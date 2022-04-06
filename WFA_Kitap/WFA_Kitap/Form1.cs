using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        
       
        
        


        List<Kitap> KitapListesi=new List<Kitap>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih t = new Tarih();
            t.Kitapadi = "Tarih";
            t.Yazaradi = "Tarih yazarı";
            t.Fiyat = 100;

            

            Psikoloji p = new Psikoloji();
            p.Kitapadi = "Psikoloji";
            p.Yazaradi = "Psikoloji yazarı";
            p.Fiyat = 100;

           

            Felsefe f = new Felsefe();
            f.Kitapadi = "Felsefe";
            f.Yazaradi = "Felsefe yazarı";
            f.Fiyat = 100;

           

            Roman r = new Roman();
            r.Kitapadi = "Roman";
            r.Yazaradi = "Roman  yazarı";
            r.Fiyat = 100;
           

            Edebiyat ed = new Edebiyat();
            ed.Kitapadi = "Edebiyat";
            ed.Yazaradi = "Edebiyat yazarı";
            ed.Fiyat = 100;

           KitapListesi.Add(t);
            KitapListesi.Add(p);
            KitapListesi.Add(r);
            KitapListesi.Add(ed);
            KitapListesi.Add(f);

            foreach(Kitap kitap in KitapListesi)
            {
                if(kitap is KitapListesi)
                {

                }

            }

           
          


        }
    }
}
