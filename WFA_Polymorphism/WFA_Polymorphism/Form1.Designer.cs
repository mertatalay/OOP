namespace WFA_Polymorphism
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
            this.btnkedi = new System.Windows.Forms.Button();
            this.btnkopek = new System.Windows.Forms.Button();
            this.btnat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnkedi
            // 
            this.btnkedi.Location = new System.Drawing.Point(196, 194);
            this.btnkedi.Name = "btnkedi";
            this.btnkedi.Size = new System.Drawing.Size(319, 126);
            this.btnkedi.TabIndex = 0;
            this.btnkedi.Text = "kedi sesi";
            this.btnkedi.UseVisualStyleBackColor = true;
            this.btnkedi.Click += new System.EventHandler(this.btnkedi_Click);
            // 
            // btnkopek
            // 
            this.btnkopek.Location = new System.Drawing.Point(761, 194);
            this.btnkopek.Name = "btnkopek";
            this.btnkopek.Size = new System.Drawing.Size(325, 126);
            this.btnkopek.TabIndex = 1;
            this.btnkopek.Text = "köpek sesi";
            this.btnkopek.UseVisualStyleBackColor = true;
            this.btnkopek.Click += new System.EventHandler(this.btnkopek_Click);
            // 
            // btnat
            // 
            this.btnat.Location = new System.Drawing.Point(1351, 194);
            this.btnat.Name = "btnat";
            this.btnat.Size = new System.Drawing.Size(308, 111);
            this.btnat.TabIndex = 2;
            this.btnat.Text = "At sesi";
            this.btnat.UseVisualStyleBackColor = true;
            this.btnat.Click += new System.EventHandler(this.btnat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2808, 1147);
            this.Controls.Add(this.btnat);
            this.Controls.Add(this.btnkopek);
            this.Controls.Add(this.btnkedi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnkedi;
        private System.Windows.Forms.Button btnkopek;
        private System.Windows.Forms.Button btnat;
    }
}

