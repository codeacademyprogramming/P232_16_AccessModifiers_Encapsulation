using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        public string Name;
        private double _price;

        
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }

        public void SetPrice(double price)
        {
            if (price >= 0)
            {
                _price = price;
            }
        }

        public double GetPrice()
        {
            return _price;
        }

    }
}
