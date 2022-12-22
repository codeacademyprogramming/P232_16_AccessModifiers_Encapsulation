using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            try
            {
                human.Age = -1;
            }
            catch (AgeRangeException e)
            {
                //Console.WriteLine("Yas 0-dan kicik ola bilmez!");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(human.Age);

            Employee emp1 = new Employee();


            //string ps;
            //bool check = true;
            //do
            //{
            //    check = true;
            //    Console.WriteLine("Pasiton:");
            //    ps = Console.ReadLine();

            //    try
            //    {
            //        emp1.Position = ps;
            //    }
            //    catch (Exception)
            //    {
            //        check = false;
            //    }

            //} while (check == false);

            string ps;
            do
            {
                Console.WriteLine("Positon:");
                ps = Console.ReadLine();

            } while (!ContainsOnlyLetter(ps));

            emp1.Position = ps;
           

            Console.WriteLine(emp1.Position);

            human.Age = 4;
            Console.WriteLine(human.Age);

            emp1.Age = 4;
            Console.WriteLine(emp1.Age);
        }

        static bool ContainsOnlyLetter(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
