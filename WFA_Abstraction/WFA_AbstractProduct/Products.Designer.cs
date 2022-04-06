
namespace WFA_AbstractProduct
{
    partial class Products
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
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtstocks = new System.Windows.Forms.TextBox();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupplier);
            this.groupBox1.Controls.Add(this.btnCategory);
            this.groupBox1.Controls.Add(this.btnProduct);
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.txtstocks);
            this.groupBox1.Controls.Add(this.nudUnitPrice);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 877);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(340, 521);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(425, 45);
            this.cmbSupplier.TabIndex = 9;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(340, 419);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(425, 45);
            this.cmbCategory.TabIndex = 8;
            // 
            // txtstocks
            // 
            this.txtstocks.Location = new System.Drawing.Point(340, 312);
            this.txtstocks.Name = "txtstocks";
            this.txtstocks.Size = new System.Drawing.Size(425, 44);
            this.txtstocks.TabIndex = 7;
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Location = new System.Drawing.Point(340, 193);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(425, 44);
            this.nudUnitPrice.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(340, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(425, 44);
            this.txtProductName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units in Stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(1082, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1349, 670);
            this.listBox1.TabIndex = 1;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(358, 600);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(348, 110);
            this.btnProduct.TabIndex = 10;
            this.btnProduct.Text = "Product Add";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(539, 761);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(288, 96);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(162, 752);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(266, 105);
            this.btnSupplier.TabIndex = 11;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2873, 1281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Products";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.TextBox txtstocks;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnCategory;
    }
}

