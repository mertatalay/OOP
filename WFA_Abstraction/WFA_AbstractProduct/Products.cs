using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AbstractProduct
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        public static List<Product> productList = new List<Product>();
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Category category in Categories.categoryList )
            {
                cmbCategory.Items.Add(category);
            }
            foreach (Supplier supplier in Suppliers.supplierList)
            {
                cmbSupplier.Items.Add(supplier);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
          
            


        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Categories cfrom=new Categories();
            cfrom.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Suppliers sform=new Suppliers();
            sform.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
