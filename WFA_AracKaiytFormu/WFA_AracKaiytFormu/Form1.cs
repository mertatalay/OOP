using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKaiytFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Araba car=new Araba();
        Araba car1=new Araba();
       
        

        private void Form1_Load(object sender, EventArgs e)
        {

            car.marka = "Renault";
            car.model = "Megane";
            car.yakittipi = "Dizel";
            car.vitestipi = "Otomatik";
            car.modelyili = 2022;

            cmbMarka.Items.Add(car.marka);
            cmbModel.Items.Add(car.model);
            cmbYakit.Items.Add(car.yakittipi);
            cmbVites.Items.Add(car.vitestipi);
            cmbmodelyili.Items.Add(car.modelyili);

            car1.marka = "Fiat";
            car1.model = "Egea";
            car1.yakittipi = "Benzin";
            car1.vitestipi = "Manuel";
            car1.modelyili = 2020;
            cmbMarka.Items.Add(car1.marka);
            cmbModel.Items.Add(car1.model);
            cmbYakit.Items.Add(car1.yakittipi);
            cmbVites.Items.Add(car1.vitestipi);
            cmbmodelyili.Items.Add(car1.modelyili);

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<Araba> arackayit = new List<Araba>();
            arackayit.Add(car);
            arackayit.Add(car1);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = cmbMarka.Text;
            lvi.SubItems.Add(cmbModel.Text);
            lvi.SubItems.Add(cmbYakit.Text);
            lvi.SubItems.Add(cmbVites.Text);
            lvi.SubItems.Add("");
            lvi.SubItems.Add(cmbmodelyili.Text);
            listView1.Items.Add(lvi);




            
            
            
            
               
                
                
                
                //string format = $"Marka: {araba.marka} Model : {araba.model} Yakıt Tipi: {araba.yakittipi}  Vites Tipi: {araba.vitestipi} Model Yılı: {araba.modelyili}";
                //listView1.Items.Add(format);
            



        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            

        }
    }
}
