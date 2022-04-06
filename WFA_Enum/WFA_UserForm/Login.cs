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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            User user = new User(); 
            user.Username=txtUserName.Text;
            user.Password= txtPassword.Text;
            User user1 = new User();
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            User user2 = new User();
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;



            if (user.Username== "admin" && user.Password=="1234")
            {
                Admin adminform=new Admin();
                adminform.Show();
                this.Hide();
                
            }
            else if (user.Username == "Moderator" && user.Password == "1234")
            {
                Moderator modform=new Moderator();  
                modform.Show();
                this.Hide();
            }
            else if (user.Username == "Member" && user.Password == "1234")
            {
                Member memberform=new Member();
                memberform.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
            }

        }
    }
}
