using Domain.Entities;
using Domain.Models.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvp.Domain.Models
{
    public sealed class ExampleModel
    {

        #region Validators
        ValueValidator _valueValidator = new ValueValidator();
        #endregion

        public IEnumerable<Example> GetAllExample()
        {
            return null;
        }

        public Example GetExample(int id)
        {
            return null;
        }

        public void CreateExample(Example example)
        {
            return;
        }

        public void UpdateExample(int id, Example example)
        {
            return;
        }

        public void DeleteExample(int id)
        {

        }
    }
}
