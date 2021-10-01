using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
    public enum ProductType { Grocery, Alcohol, Chemicals, Beauty }
    public class Product
    {
        public  DateTime date { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }

        public Product(ProductType productType,DateTime dateTime)
        {
            ProductType = productType;
            date = dateTime;           
        }
        

        public override string ToString()
        {
            return $"{Name}-{Price}UAH-{ProductType}-{date.ToShortDateString()}";
        }

    }
}
