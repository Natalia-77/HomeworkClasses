using System;

namespace HomeworkClassesSS
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Product product = new Product((ProductType)0, new DateTime(2020, 10, 10));
            product.Name = "Ahmad tea";
            product.Price = 28.45M;
            Console.WriteLine(product.ToString());

        }
    }
}
