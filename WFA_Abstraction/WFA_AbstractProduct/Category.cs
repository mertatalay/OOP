using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_AbstractProduct.FakeDatabase;


namespace WFA_AbstractProduct
{
    public class Category:Database
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return CategoryName+ " " + Description;
        }

       
        
        
        


    }
}
