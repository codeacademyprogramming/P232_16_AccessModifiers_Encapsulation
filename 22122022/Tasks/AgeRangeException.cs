using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class AgeRangeException:Exception
    {
        public AgeRangeException(string message):base(message)
        {

        }
    }
}
