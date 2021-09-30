using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
    public class Employer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; }            
        public decimal Salary { get; set; }

        public Employer(string name,string surname, DateTime date,decimal salary)
        {
             Name = name; ;
            Surname=surname;
            Date=date;


        }
    }
}
