using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Validators
{
    /// <summary>
    /// Validate information passed to the models here
    /// </summary>
    internal sealed class ValueValidator
    {
        /// <summary>
        /// exposed method
        /// </summary>
        internal void Validate(string value)
        {
            if (ContainsNumbers(value))
            {
                throw new ContainsNumbersException();
            }
            return;
        }

        /// <summary>
        /// helper method for exposed method 
        /// </summary>
        private bool ContainsNumbers(string value)
        {
            return value.Any(char.IsDigit);
        }
    }
}
