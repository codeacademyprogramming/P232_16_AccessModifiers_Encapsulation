using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Employee:Human
    {
        public double Salary;
        private string _position;

        public string Position
        {
            get => _position;
            set
            {
                if (ContainsOnlyLetter(value))
                    _position = value;
                else
                    throw new FormatException();
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new AgeRangeException("Age deyrei 18-dan kicik ola bilmez!");
                }
            }
        }

       
    }
}
