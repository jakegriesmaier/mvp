using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataAccess.ExampleDataAccess
{
    internal abstract class ExampleDataAccessBase
    {

        public IEnumerable<Example> GetAllExamples()
        {
            return GetAllExamplesCore();
        }

        public Example GetExample(int id)
        {
            return GetExampleCore(id);
        }

        public void CreateExample(Example example)
        {
            CreateExampleCore(example);
        }

        public void UpdateExample(Example example)
        {
            UpdateExampleCore(example);
        }

        public void DeleteExample(int id)
        {
            DeleteExampleCore(id);
        }

        #region Required Methods 
        protected abstract IEnumerable<Example> GetAllExamplesCore();
        protected abstract Example GetExampleCore(int id);
        protected abstract void CreateExampleCore(Example example);
        protected abstract void UpdateExampleCore(Example example);
        protected abstract void DeleteExampleCore(int id);
        #endregion
    }
}
