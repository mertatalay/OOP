namespace WFA_inheritance_Computer
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
            this.lstanakart = new System.Windows.Forms.ListBox();
            this.lstekrankarti = new System.Windows.Forms.ListBox();
            this.lstislemci = new System.Windows.Forms.ListBox();
            this.lstlaptop = new System.Windows.Forms.ListBox();
            this.lstmasaustu = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstanakart
            // 
            this.lstanakart.FormattingEnabled = true;
            this.lstanakart.ItemHeight = 37;
            this.lstanakart.Location = new System.Drawing.Point(59, 70);
            this.lstanakart.Name = "lstanakart";
            this.lstanakart.Size = new System.Drawing.Size(740, 448);
            this.lstanakart.TabIndex = 0;
            this.lstanakart.DoubleClick += new System.EventHandler(this.lstanakart_DoubleClick);
            // 
            // lstekrankarti
            // 
            this.lstekrankarti.FormattingEnabled = true;
            this.lstekrankarti.ItemHeight = 37;
            this.lstekrankarti.Location = new System.Drawing.Point(882, 70);
            this.lstekrankarti.Name = "lstekrankarti";
            this.lstekrankarti.Size = new System.Drawing.Size(561, 448);
            this.lstekrankarti.TabIndex = 1;
            this.lstekrankarti.DoubleClick += new System.EventHandler(this.lstekrankarti_DoubleClick);
            // 
            // lstislemci
            // 
            this.lstislemci.FormattingEnabled = true;
            this.lstislemci.ItemHeight = 37;
            this.lstislemci.Location = new System.Drawing.Point(1541, 61);
            this.lstislemci.Name = "lstislemci";
            this.lstislemci.Size = new System.Drawing.Size(477, 448);
            this.lstislemci.TabIndex = 2;
            // 
            // lstlaptop
            // 
            this.lstlaptop.FormattingEnabled = true;
            this.lstlaptop.ItemHeight = 37;
            this.lstlaptop.Location = new System.Drawing.Point(50, 573);
            this.lstlaptop.Name = "lstlaptop";
            this.lstlaptop.Size = new System.Drawing.Size(712, 448);
            this.lstlaptop.TabIndex = 3;
            // 
            // lstmasaustu
            // 
            this.lstmasaustu.FormattingEnabled = true;
            this.lstmasaustu.ItemHeight = 37;
            this.lstmasaustu.Location = new System.Drawing.Point(1063, 573);
            this.lstmasaustu.Name = "lstmasaustu";
            this.lstmasaustu.Size = new System.Drawing.Size(555, 448);
            this.lstmasaustu.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(2201, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(636, 781);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2685, 874);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2929, 1116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstmasaustu);
            this.Controls.Add(this.lstlaptop);
            this.Controls.Add(this.lstislemci);
            this.Controls.Add(this.lstekrankarti);
            this.Controls.Add(this.lstanakart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstanakart;
        private System.Windows.Forms.ListBox lstekrankarti;
        private System.Windows.Forms.ListBox lstislemci;
        private System.Windows.Forms.ListBox lstlaptop;
        private System.Windows.Forms.ListBox lstmasaustu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

