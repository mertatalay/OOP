using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdan
{
    public partial class AdminForm : Form
    {
        public AdminForm(Kullanici kullanici)
        {
            adminkullanici = kullanici;
            InitializeComponent();
        }
        KullaniciForm kullaniciForm = new KullaniciForm();
        Kullanici adminkullanici=new Kullanici();
        List<Menu>menuList=new List<Menu>();
        List<Ekstra> ekstraList = new List<Ekstra>();
        Menu menu=new Menu();
        Ekstra ekstra=new Ekstra();
        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            menu.MenuAdi = txtMenu.Text;
            menu.MenuFiyat = nudFiyat.Value;
            menuList.Add(menu);
            listBox1.Items.Add(menu);






        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            ekstra.EkstarAdi = txtExtra.Text;
            ekstra.ExtraFiyati = nudExtraFiyat.Value;
            ekstraList.Add(ekstra);
            listBox2.Items.Add(ekstra);



        }

        private void btnMenuOnayla_Click(object sender, EventArgs e)
        {
            
                kullaniciForm.cmbMenu.Items.Add(menu.MenuAdi);
            
           
        }

        private void btnKullaniciForm_Click(object sender, EventArgs e)
        {
            kullaniciForm.Show();
            this.Hide();
        }

        private void btnEkstraOnayla_Click(object sender, EventArgs e)
        {
            

            
            
            
        }
    }
}
