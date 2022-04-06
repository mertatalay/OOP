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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<Kullanici> kullaniciList = new List<Kullanici>()
        {
            new Kullanici{KullaniciAdi="admin",Parola="1234",Rol=Rol.admin},
            new Kullanici{KullaniciAdi="user",Parola="1234",Rol=Rol.kullanici},
            
        };
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullaniciAdi.Text.ToLower();
            string parola=txtParola.Text;

            foreach(Kullanici kullanici in kullaniciList)
            {
               if( kullanici.KullaniciAdi==kullaniciadi && kullanici.Parola == parola)
               {
                    switch (kullanici.Rol)
                    {
                        case Rol.admin:
                            AdminForm adminForm = new AdminForm(kullanici);
                            adminForm.Show();
                            this.Hide();
                            break;
                        case Rol.kullanici:
                            KullaniciForm kullaniciForm = new KullaniciForm();
                            kullaniciForm.Show();
                            this.Hide();
                            break;
                            default:
                            break;


                    }
                        
               }
            }
        }
    }
}
