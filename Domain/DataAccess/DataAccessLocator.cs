using Domain.DataAccess.ExampleDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess
{
    internal static class DataAccessLocator
    {
        /// <summary>
        /// creates an instance of an ExampleDataAccess object, can switch this out without impacting the rest of the code
        /// </summary>
        /// <returns></returns>
        public static ExampleDataAccessBase GetExampleDataAccess()
        {
            return new ExampleDataAccessImplementation();
        }

    }
}
