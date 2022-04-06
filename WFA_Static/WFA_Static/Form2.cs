using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Static
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Personel isimli class dan kaç adet instance alınırsa mesaj kutusunda göstersin

            Personel p = new Personel();

            MessageBox.Show(Personel.PersonelSayisi.ToString());
        }
    }
}
