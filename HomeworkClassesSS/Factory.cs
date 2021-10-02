using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
     partial class Factory
    {
        public string Name { get; set; }
        public Employee[] Employee { get; set; }
        public Product[] Products { get; set; }
        public Factory(string namefactory)
        {
            Name = namefactory;

        }

        public void AddEmployee()
        {
            Employee = new[] {
               new Employee("Petro","Ivanov",new DateTime(2008,10,2),15620 ),
               new Employee("Stepan","Boroda",new DateTime(1985,05,05),12300)

            };
            

        }

       

        public void AddProduct()
        {
            Products = new[]
            {
                new Product((ProductType)3,new DateTime(2021, 08, 12))
                {
                    Name="Dove",
                    Price=52.45M
                },
                new Product((ProductType)2,new DateTime(2021, 09, 20))
                {
                    Name="Martini",
                    Price=299.44M
                }
            };
        }
        public void Show()
        {
            foreach (var item in Employee)
            {
                Console.WriteLine($"{item.Name} {item.Surname} Date of birth:{item.Date.ToShortDateString()} salary:{item.Salary} UAH");
            }

            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Name} {product.Price} Type:{product.ProductType} Product date:{product.date.ToShortDateString()}");
            }
        }
       


    }
}
