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
        public Employee[] Employee { get; set; }
        public Product[] products { get; set; }
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

        }
        public void Show()
        {
            foreach (var item in Employee)
            {
                Console.WriteLine($"{item.Name} {item.Surname} Date of birth:{item.Date.ToShortDateString()} salary:{item.Salary} UAH");
            }
        }
       


    }
}
