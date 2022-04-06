using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                int gelendeger=Convert.ToInt32(txtdeger.Text);
                Gunler gunad = (Gunler)gelendeger;
                MessageBox.Show(gunad.ToString());


            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Haftanın Menüsü;
            //Pazartesi-Patlıcan Musakka
            //Salı -fırında makarna
            //çarşamba-kuru fasülye pilav
            //perşembe - pilav
            //cuma-pilav
            //cumartesi-fırında tavuk
            //pazar-tatil

            try
            {
                int gelendeger = Convert.ToInt32(txtdeger.Text);
                Gunler gunad = (Gunler)gelendeger;
                string menu = "";
                switch (gunad)
                {
                    case Gunler.Pazartesi:
                        menu= "Patlıcan Musakka";
                        break;
                    case Gunler.salı:
                        menu = "fırında makarna";
                        break;
                    case Gunler.çarşamba:
                        menu = "kuru fasülye pilav";
                        break;
                    case Gunler.perşembe:
                        menu = "pilav";
                        break;
                    case Gunler.cuma:
                        menu = "pilav";
                        break;
                    case Gunler.cumartesi:
                        menu = "fırında tavuk";
                        break;
                    case Gunler.pazar:
                        menu = "tatil";
                        break;
                    default:
                        break;

                       
                }

                MessageBox.Show(menu);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
