using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Human
    {
        private string _name;
        protected int _age;

        public int Age
        {
            get => _age;
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new AgeRangeException("Age deyrei 0-dan kicik ola bilmez!");
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (ContainsOnlyLetter(value))
                {
                    _name = value;
                }
            }
        }

        protected bool ContainsOnlyLetter(string str)
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
