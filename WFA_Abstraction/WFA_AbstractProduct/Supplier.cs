using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WFA_AbstractProduct
{
    public class Supplier
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return CompanyName + " " + PhoneNumber + " " + Address;
        }
    }
}
