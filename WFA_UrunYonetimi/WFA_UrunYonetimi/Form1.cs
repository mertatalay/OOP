using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UrunYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Masaustu> masaustuList = new List<Masaustu>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
           Masaustu masaustu = new Masaustu();
            masaustu.EkranKarti = "NVDİA";
            masaustu.RAM = 8;
            masaustu.Fiyat = 5000;
            masaustu.olustur();
            masaustuList.Add(masaustu);

            MessageBox.Show(masaustu.ToString());



        }
    }
}
