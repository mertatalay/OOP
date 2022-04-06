
namespace WFA_Abstraction
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstKeman = new System.Windows.Forms.ListBox();
            this.lstKlasikGitar = new System.Windows.Forms.ListBox();
            this.lstPiyano = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 225);
            this.listBox1.TabIndex = 0;
            // 
            // lstKeman
            // 
            this.lstKeman.FormattingEnabled = true;
            this.lstKeman.Location = new System.Drawing.Point(266, 25);
            this.lstKeman.Name = "lstKeman";
            this.lstKeman.Size = new System.Drawing.Size(169, 95);
            this.lstKeman.TabIndex = 0;
            // 
            // lstKlasikGitar
            // 
            this.lstKlasikGitar.FormattingEnabled = true;
            this.lstKlasikGitar.Location = new System.Drawing.Point(461, 25);
            this.lstKlasikGitar.Name = "lstKlasikGitar";
            this.lstKlasikGitar.Size = new System.Drawing.Size(169, 95);
            this.lstKlasikGitar.TabIndex = 0;
            // 
            // lstPiyano
            // 
            this.lstPiyano.FormattingEnabled = true;
            this.lstPiyano.Location = new System.Drawing.Point(655, 25);
            this.lstPiyano.Name = "lstPiyano";
            this.lstPiyano.Size = new System.Drawing.Size(169, 95);
            this.lstPiyano.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.lstPiyano);
            this.Controls.Add(this.lstKlasikGitar);
            this.Controls.Add(this.lstKeman);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstKeman;
        private System.Windows.Forms.ListBox lstKlasikGitar;
        private System.Windows.Forms.ListBox lstPiyano;
    }
}

