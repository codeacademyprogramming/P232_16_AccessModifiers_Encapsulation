using System;

namespace MenuTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook[] notebooks = new Notebook[4];

            notebooks[0] = new Notebook("Macbook Pro 15", 3500);
            notebooks[1] = new Notebook("Macbook Pro 13", 2500);
            notebooks[2] = new Notebook("Macbook Air", 1500);
            notebooks[3] = new Notebook("Asus ROG", 3200);

            string opt;
            do
            {
                Console.WriteLine("1. Notebooklar uzerinde axtaris");
                Console.WriteLine("2. Yeni notebook yarat");
                Console.WriteLine("0. Menudan cix");

                opt = Console.ReadLine();

                if (opt == "1")
                {
                    Console.WriteLine("Axtaris deyerini daxil edin:");
                    string search = Console.ReadLine();

                    var filteredArr = SearchByName(notebooks, search);

                    ShowNotebooksInfo(filteredArr);
                }
                else if (opt == "2")
                {
                    
                    try
                    {
                        var notebook = CreateNotebook();
                        Array.Resize(ref notebooks, notebooks.Length + 1);
                        notebooks[notebooks.Length - 1] = notebook;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Xeta bas verdi, yeniden cehd edin");
                        Console.WriteLine("Xeta: "+e.Message);

                    }
                }

            } while (opt!="0");
            
        }

        static Notebook[] SearchByName(Notebook[] arr,string search)
        {
            Notebook[] newArr = new Notebook[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Name.Contains(search))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        }

        static void ShowNotebooksInfo(Notebook[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].GetInfo());
            }
        }

        static void Add(ref Notebook[] arr,Notebook value)
        {
            Notebook[] newArr = new Notebook[arr.Length + 1];

            for (int i = 0;i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            arr = newArr;
        }

        static Notebook CreateNotebook()
        {
            Console.WriteLine("Notebook yarat:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || name.Length<3)
            {
                throw new NameFormatException("Name deyeri minimum 3 uzunlquda olmalidir!");
            }

            double price;
            bool check = true;
            do
            {
                Console.WriteLine("enter price:");
                string priceStr = Console.ReadLine();
                check  = double.TryParse(priceStr, out price);

                if (check == false)
                    Console.WriteLine("Price deyeri eded olmalidir");

            } while (!check);


            byte ram;

            do
            {
                Console.WriteLine("Ram:");
                string ramStr = Console.ReadLine();
                check = byte.TryParse(ramStr,out ram);

                if (check == false)
                    Console.WriteLine("Ram deyeri eded olmalidir");

            } while (!check);

          

            return new Notebook(name, price, ram);
        }

        static bool TryParseByte(string str,out byte num)
        {
            try
            {
                num = Convert.ToByte(str);
                return true;
            }
            catch (Exception)
            {
                num = 0;
                return false;
            }
        }


    }
}
