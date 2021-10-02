using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesSS
{
    partial class Factory 
    {
        public decimal GetTotalSalary()
        {
            decimal res = 0;
            foreach (var item in Employee)
            {
                res += item.Salary;
            }
            return res;
        }

        public decimal GetAvgSalary()
        {
            // int count = 0;
            decimal res2 = 0;
           int count= Employee.Count();
            foreach (var item in Employee)
            {
                res2 += item.Salary;
            }
            return res2 / count;
        }


    }
}
