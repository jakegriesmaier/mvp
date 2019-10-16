using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.DataAccess.ExampleDataAccess
{
    /// <summary>
    /// Database specific implementation for DataAccess for an 'Example' object
    /// </summary>
    internal sealed class ExampleDataAccessImplementation : ExampleDataAccessBase
    {
        protected override void CreateExampleCore(Example example)
        {
            return;//implementation for storing 'Example' in the database would go here
        }

        protected override void DeleteExampleCore(int id)
        {
            return;//implementation for deleting 'Example' with 'id' = id in the database would go here
        }

        protected override IEnumerable<Example> GetAllExamplesCore()
        {
            return new List<Example>();//implementation for getting all of the 'Example' object from the database would go here
        }

        protected override Example GetExampleCore(int id)
        {
            return new Example();//implementation for getting an 'Example' with 'id' = id from the database would go here
        }

        protected override void UpdateExampleCore(Example example)
        {
            return;//implementation for updating a particular 'Example' in the database would go here
        }
    }
}
