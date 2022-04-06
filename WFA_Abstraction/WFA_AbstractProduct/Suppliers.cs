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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
        public static List<Supplier> supplierList = new List<Supplier>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(); 
            supplier.CompanyName =txtCompanyName.Text;
            supplier.PhoneNumber =txtPhoneNumber.Text;
            supplier.Address=txtAdress.Text;
            supplierList.Add(supplier);
            listBox1.DataSource = supplierList;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products pform=new Products();
            pform.Show();
            this.Hide();
        }
    }
}
