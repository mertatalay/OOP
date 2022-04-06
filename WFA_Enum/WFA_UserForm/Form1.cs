using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_UserForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //3 adet rol tanımlayın
                //admin,member,moderator

            //4 ayrı form olutlurun
                //login
                //admin
                //member
                //visitor

            //3 farklı kullanıcı oluşturun
                //username
                //password
                //role

            //uygulama çalıştırıldığında login form açılacak. kullanıcı bilgileri girlecek(username,password)kullanıcı bilgilerine göre giriş yapan admin ise adminform açılacak.member ise memberform açılacak, visitor ise visitorform açılacak.
            

        }
    }
}
