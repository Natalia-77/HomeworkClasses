using System;

namespace HomeworkClassesSS
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product(0, new DateTime(2020, 10, 10))
            {
                Name = "Ahmad tea",
                Price = 28.45M
            };

            //Console.WriteLine(product.ToString());
            Factory factory = new Factory("Willy Wonca");
            factory.AddEmployee();
            factory.AddProduct();
            factory.Show();

           

        }
    }
}
