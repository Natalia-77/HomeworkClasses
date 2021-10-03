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
        //Enter from console.
        public void AddEmployeersArray()
        {
            Console.WriteLine("Enter count of emloyeers");
            int r = int.Parse(Console.ReadLine());
            Employee = new Employee[r];
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"Enter birth day {i + 1} employee(format year.mouth.day):");
                DateTime dt=Convert.ToDateTime(Console.ReadLine());                
                Employee[i] = new Employee(dt);
                Console.WriteLine($"Enter name {i + 1} employee:");
                Employee[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter surname {i + 1} employee:");
                Employee[i].Surname = Console.ReadLine();        
                Console.WriteLine($"Enter salary {i + 1} employee:");
                Employee[i].Salary = int.Parse(Console.ReadLine());

            }



        }

        public void AddProductArray()
        {
            Console.WriteLine("Enter count of products");
            int r = int.Parse(Console.ReadLine());
            Products = new Product[r];
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"Enter produce day {i + 1}product(format year.mouth.day):");
                DateTime dt = Convert.ToDateTime(Console.ReadLine());
                Products[i] = new Product(dt);
                Console.WriteLine($"Enter name {i + 1} product:");
                Products[i].Name = Console.ReadLine();               
                Console.WriteLine($"Enter price {i + 1} product:");
                Products[i].Price = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter type {i + 1} product:");
                Console.WriteLine("0.Grocery, 1.Alcohol, 2.Chemicals,3.Beauty ");
                Products[i].ProductType = (ProductType)int.Parse(Console.ReadLine());

            }



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
                Console.WriteLine($"{item.Name} {item.Surname} BirthDay:{item.Date.ToShortDateString()} salary:{item.Salary} UAH");
            }

            //foreach (var product in Products)
            //{
            //    Console.WriteLine($"{product.Name} {product.Price} Type:{product.ProductType} Product date:{product.date.ToShortDateString()}");
            //}
        }
       


    }
}
