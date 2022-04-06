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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        public static List<Category> categoryList = new List<Category>();
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName =txtCategoryName.Text;
            category.Description=txtDescription.Text;
           
            categoryList.Add(category);
            listBox1.DataSource = categoryList;
            
            
             



        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Products pform=new Products();
            pform.Show();
            this.Hide();
        }
    }
}
