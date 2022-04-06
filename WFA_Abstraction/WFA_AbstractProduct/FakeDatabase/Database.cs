using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstractProduct.FakeDatabase
{
    public  class Database
    {
       List<Product> productList = new List<Product>();
       List<Category> categoryList = new List<Category>();
       List<Supplier> supplierList = new List<Supplier>();
    }
}
