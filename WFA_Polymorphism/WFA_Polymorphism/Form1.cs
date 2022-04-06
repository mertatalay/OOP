using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hayvan hayvan = new Hayvan();
        private void btnkedi_Click(object sender, EventArgs e)
        {
            Kedi kedi=new Kedi();
            kedi.AyakSayisi = 4;
            kedi.Nankormu = true;
            kedi.Ucar = false;
            string ses = kedi.sescikar();
            MessageBox.Show(ses);
        }

        private void btnkopek_Click(object sender, EventArgs e)
        {
            Kopek kopek=new Kopek();
            string ses = kopek.sescikar();
            MessageBox.Show(ses);
        }

        private void btnat_Click(object sender, EventArgs e)
        {
            At at=new At();
            string ses = at.sescikar();
            MessageBox.Show(ses);
        }
    }
}
