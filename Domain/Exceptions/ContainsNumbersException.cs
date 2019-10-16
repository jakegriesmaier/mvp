using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    internal class ContainsNumbersException : Exception
    {
        public ContainsNumbersException() : base("Value Contains Numbers")
        {
            
        }

    }
}
