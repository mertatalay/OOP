using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KitapKutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void urunekle()
        {
            Kitap kitap = new Kitap();
            Giyim giyim = new Giyim();
            Elektronik elektronik = new Elektronik();
            switch (cmbaltkategori.Text)
            {
                case "Edebiyat":
                    kitap.urunadi = "Edebiyat Kitabı";
                    kitap.yazari = "Edebiyat Yazarı";
                    kitap.fiyat = 50;
                    label8.Text = kitap.urunadi;
                    label9.Text = kitap.yazari;
                    nudfiyat.Value = kitap.fiyat;
                    break;
                case "Felsefe":
                    kitap.urunadi = "Felsefe Kitabı";
                    kitap.yazari = "Felsefe Yazarı";
                    kitap.fiyat = 75;
                    label8.Text = kitap.urunadi;
                    label9.Text = kitap.yazari;
                    nudfiyat.Value = kitap.fiyat;
                    break;
                case "Psikoloji":
                    kitap.urunadi = "Psikoloji Kitabı";
                    kitap.yazari = "Psikoloji Yazarı";
                    kitap.fiyat = 100;
                    label8.Text = kitap.urunadi;
                    label9.Text = kitap.yazari;
                    nudfiyat.Value = kitap.fiyat;
                    break;
                case "Roman":
                    kitap.urunadi = "Roman Kitabı";
                    kitap.yazari = "Roman Yazarı";
                    kitap.fiyat = 80;
                    label8.Text = kitap.urunadi;
                    label9.Text = kitap.yazari;
                    nudfiyat.Value = kitap.fiyat;
                    break;
                case "Tarih":
                    kitap.urunadi = "Tarih Kitabı";
                    kitap.yazari = "Tarih Yazarı";
                    kitap.fiyat = 45;
                    label8.Text = kitap.urunadi;
                    label9.Text = kitap.yazari;
                    nudfiyat.Value = kitap.fiyat;
                    break;
                case "Erkek Giyim":
                    giyim.Marka = "Mavi";
                    giyim.beden = "Small";
                    giyim.fiyat = 250;
                    label8.Text = giyim.Marka;
                    label9.Text = giyim.beden;
                    nudfiyat.Value = giyim.fiyat;
                    break;
                case "Kadın Giyim":
                    giyim.Marka = "Bershka";
                    giyim.beden = "Large";
                    giyim.fiyat = 125;
                    label8.Text = giyim.Marka;
                    label9.Text = giyim.beden;
                    nudfiyat.Value = giyim.fiyat;
                    break;
                case "Telefon":
                    elektronik.Marka = "Samsung";
                    elektronik.model = "Note9";
                    elektronik.fiyat = 5500;
                    label8.Text = elektronik.Marka;
                    label9.Text = elektronik.model;
                    nudfiyat.Value = elektronik.fiyat;
                    break;

            }










        }
        void Temizle()
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;

                }



                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nudfiyat.Value = 0;

                }
                else if (ctrl is Label)
                {
                    Label lbl = (Label)ctrl;
                    label8.Text = "";
                    label9.Text = "";
                    label10.Text = "";
                }

                
            }
        }

        
        

            string[] Altkategorikitap = { "Edebiyat", "Felsefe", "Psikoloji", "Roman", "Tarih" };
        string[] Altkategorigiyim = { "Erkek Giyim", "Kadın Giyim" };
        string[] Altkategorielektronik = { "Telefon" };
        string[] Kategori = { "Kitap" ,"Giyim","Elektronik"};

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (string altkategorikitap in Altkategorikitap)
            {
                cmbaltkategori.Items.Add(altkategorikitap);
                
            }
            foreach(string altkategorigiyim in Altkategorigiyim)
            {
                cmbaltkategori.Items.Add(altkategorigiyim);
            }
            foreach(string altkategorielektronik in Altkategorielektronik)
            {
                cmbaltkategori.Items.Add(altkategorielektronik);
            }
            
            foreach(string kategorihepsi in Kategori)
            {
                cmbkategori.Items.Add(kategorihepsi);
            }

            

            
           

        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbaltkategori.Items.Clear();
            switch (cmbkategori.Text)
            {
                case "Kitap":
                    foreach (string altkategorikitap in Altkategorikitap)
                    {
                        cmbaltkategori.Items.Add(altkategorikitap);

                    }
                    break;
                case "Giyim":
                    foreach (string altkategorigiyim in Altkategorigiyim)
                    {
                        cmbaltkategori.Items.Add(altkategorigiyim);
                    }
                    break;
                case "Elektronik":
                    foreach (string altkategorielektronik in Altkategorielektronik)
                    {
                        cmbaltkategori.Items.Add(altkategorielektronik);
                    }
                    break;

            }
                
        }

        private void cmbaltkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            urunekle();
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (cmbaltkategori.Text == "Telefon")
            {

                string format = string.Format($"marka : {label8.Text}, Model: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstElektronik.Items.Add(format);
            }
            else if(cmbaltkategori.Text == "Erkek Giyim")
            {
                string format = string.Format($"marka : {label8.Text}, Beden: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstErkekGiyim.Items.Add(format);
            }
            else if (cmbaltkategori.Text == "Kadın Giyim")
            {
                string format = string.Format($"marka : {label8.Text}, Beden: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstKadinGiyim.Items.Add(format);
            }
            else if (cmbaltkategori.Text == "Edebiyat")
            {

                string format = string.Format($"Kitap Adı : {label8.Text}, Yazar: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstEdebiyat.Items.Add(format);  
            }
            else if (cmbaltkategori.Text == "Felsefe")
            {
                string format = string.Format($"Kitap Adı : {label8.Text}, Yazar: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstFelsefe.Items.Add(format);
            }
            else if (cmbaltkategori.Text == "Psikoloji")
            {
                string format = string.Format($"Kitap Adı : {label8.Text}, Yazar: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstPsikoloji.Items.Add(format);
            }
            else if (cmbaltkategori.Text == "Roman")
            {
                string format = string.Format($"Kitap Adı : {label8.Text}, Yazar: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstRoman.Items.Add(format);
            }
            else if (cmbaltkategori.Text == "Tarih")
            {
                string format = string.Format($"Kitap Adı : {label8.Text}, Yazar: {label9.Text}, Fiyat: {nudfiyat.Value}");
                lstTarih.Items.Add(format);
            }


            Temizle();
               

                   
                
            
            
                
            
        }
    }
}
