using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
     public class Factory
    {
        public string Name { get; set; }
        private Employee[] employeers = new Employee[5];
        private Product[] products = new Product[20];
       

        public Employee[] Employers
        {
            get
            {
                return employeers;
            }
            set
            {
                employeers = value;
            }
        }

        public Product[] Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }




    }
}
