using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTask
{
    internal class NameFormatException:Exception
    {
        public NameFormatException(string message):base(message)
        {

        }
    }
}
