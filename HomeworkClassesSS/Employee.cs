using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; }            
        public decimal Salary { get; set; }

        public Employee(DateTime date)
        {
            Date = date;
        }
        public Employee(string name, string surname, decimal salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;

        }
        public Employee(string name, string surname, DateTime date, decimal salary):this(name,surname,salary)
        {
            Date = date;
        }

       
        
    }
}
