using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_AbstractProduct.FakeDatabase;
namespace WFA_AbstractProduct
{
    public class Product:BaseClass
    {
       
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        public override string ToString()
        {
            return ProductName + "" + UnitPrice + "" + UnitsInStock + "" + Category + "" + Supplier;
        }

        public override string Add()
        {
            
            return "Ürün Eklendi!";
        }

        public override string Delete()
        {
            return "Ürün Silindi!";
        }

        public override string List()
        {
            return "Ürün Listeleniyor...";
        }

        public override string Update()
        {
            return "Ürün güncellendi";
        }

        public string Promotion(double val)
        {
            return "Promosyon uygulandı";
        }
    }
}
