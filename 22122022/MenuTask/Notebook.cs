using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTask
{
    internal class Notebook:Product
    {
        public Notebook(string name,double price):base(name,price)
        {

        }

        public Notebook(string name, double price, byte ram) : base(name, price)
        {
            this.RAM = ram;
        }
        public byte RAM = 4;

    }
}
