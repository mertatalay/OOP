namespace WFA_AracListesi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txturtyil = new System.Windows.Forms.TextBox();
            this.txtsase = new System.Windows.Forms.TextBox();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.cmbyakit = new System.Windows.Forms.ComboBox();
            this.cmbvites = new System.Windows.Forms.ComboBox();
            this.txtjant = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.cmbkasa = new System.Windows.Forms.ComboBox();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudfiyat);
            this.groupBox1.Controls.Add(this.cmbkasa);
            this.groupBox1.Controls.Add(this.txtrenk);
            this.groupBox1.Controls.Add(this.txtjant);
            this.groupBox1.Controls.Add(this.cmbvites);
            this.groupBox1.Controls.Add(this.cmbyakit);
            this.groupBox1.Controls.Add(this.txtmotor);
            this.groupBox1.Controls.Add(this.txtsase);
            this.groupBox1.Controls.Add(this.txturtyil);
            this.groupBox1.Controls.Add(this.txtmodel);
            this.groupBox1.Controls.Add(this.txtmarka);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 935);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araba Özellikleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üretim Yılı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şase No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motor Gücü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yakıt Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 568);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vites Tip";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = "Jant Boyut";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 750);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 37);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 814);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kasa Tip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 874);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 37);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fiyat";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(90, 973);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(318, 81);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(260, 97);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(278, 44);
            this.txtmarka.TabIndex = 11;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(260, 176);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(278, 44);
            this.txtmodel.TabIndex = 12;
            // 
            // txturtyil
            // 
            this.txturtyil.Location = new System.Drawing.Point(260, 252);
            this.txturtyil.Name = "txturtyil";
            this.txturtyil.Size = new System.Drawing.Size(278, 44);
            this.txturtyil.TabIndex = 13;
            // 
            // txtsase
            // 
            this.txtsase.Location = new System.Drawing.Point(260, 327);
            this.txtsase.Name = "txtsase";
            this.txtsase.Size = new System.Drawing.Size(278, 44);
            this.txtsase.TabIndex = 14;
            // 
            // txtmotor
            // 
            this.txtmotor.Location = new System.Drawing.Point(260, 417);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.Size = new System.Drawing.Size(278, 44);
            this.txtmotor.TabIndex = 15;
            // 
            // cmbyakit
            // 
            this.cmbyakit.FormattingEnabled = true;
            this.cmbyakit.Location = new System.Drawing.Point(260, 496);
            this.cmbyakit.Name = "cmbyakit";
            this.cmbyakit.Size = new System.Drawing.Size(278, 45);
            this.cmbyakit.TabIndex = 16;
            // 
            // cmbvites
            // 
            this.cmbvites.FormattingEnabled = true;
            this.cmbvites.Location = new System.Drawing.Point(260, 582);
            this.cmbvites.Name = "cmbvites";
            this.cmbvites.Size = new System.Drawing.Size(278, 45);
            this.cmbvites.TabIndex = 17;
            // 
            // txtjant
            // 
            this.txtjant.Location = new System.Drawing.Point(260, 659);
            this.txtjant.Name = "txtjant";
            this.txtjant.Size = new System.Drawing.Size(278, 44);
            this.txtjant.TabIndex = 18;
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(260, 743);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(278, 44);
            this.txtrenk.TabIndex = 19;
            // 
            // cmbkasa
            // 
            this.cmbkasa.FormattingEnabled = true;
            this.cmbkasa.Location = new System.Drawing.Point(260, 814);
            this.cmbkasa.Name = "cmbkasa";
            this.cmbkasa.Size = new System.Drawing.Size(278, 45);
            this.cmbkasa.TabIndex = 20;
            // 
            // nudfiyat
            // 
            this.nudfiyat.Location = new System.Drawing.Point(260, 874);
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(278, 44);
            this.nudfiyat.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(755, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(2093, 915);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 221;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 192;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Üretim Yılı";
            this.columnHeader3.Width = 227;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Şase No";
            this.columnHeader4.Width = 173;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Motor Gücü";
            this.columnHeader5.Width = 210;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yakıt Tipi";
            this.columnHeader6.Width = 190;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Vites Tipi";
            this.columnHeader7.Width = 169;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Jant Boyutu";
            this.columnHeader8.Width = 191;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Renk";
            this.columnHeader9.Width = 139;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kasa Tipi";
            this.columnHeader10.Width = 137;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Fiyat";
            this.columnHeader11.Width = 139;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "KDV Dahil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2938, 1120);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.ComboBox cmbkasa;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtjant;
        private System.Windows.Forms.ComboBox cmbvites;
        private System.Windows.Forms.ComboBox cmbyakit;
        private System.Windows.Forms.TextBox txtmotor;
        private System.Windows.Forms.TextBox txtsase;
        private System.Windows.Forms.TextBox txturtyil;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

