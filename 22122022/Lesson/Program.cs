using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            pr1.Name = "Product 1";

            pr1.SetPrice(44);
            pr1.SetPrice(-4);



            Console.WriteLine(pr1.GetPrice());

            pr1.Price = 50;
            pr1.Price = -4;


            Console.WriteLine(pr1.Price);

        }
    }
}
