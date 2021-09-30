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
        private Employer[] employeers = new Employer[5];
        private Product[] products = new Product[20];
       

        public Employer[] Employers
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
