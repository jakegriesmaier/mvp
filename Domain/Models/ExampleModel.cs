using Domain.DataAccess;
using Domain.DataAccess.ExampleDataAccess;
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

        #region Data Access Objects
        ExampleDataAccessBase _exampleDataAccessor = DataAccessLocator.GetExampleDataAccess();
        #endregion

        public IEnumerable<Example> GetAllExample()
        {
            //VALIDATE, throws error if not valid
            //DO DATA ACCESS CALLS
            var result = _exampleDataAccessor.GetAllExamples();
            //RETURN
            return result;
        }

        public Example GetExample(int id)
        {
            //VALIDATE, throws error if not valid
            //DO DATA ACCESS CALLS
            var result = _exampleDataAccessor.GetExample(id);
            //RETURN
            return result;
        }

        public void CreateExample(Example example)
        {
            //VALIDATE, throws error if not valid
            _valueValidator.Validate(example.value);
            //DO DATA ACCESS CALLS
            _exampleDataAccessor.CreateExample(example);
            //RETURN
            return;
        }

        public void UpdateExample(int id, Example example)
        {
            //VALIDATE, throws error if not valid
            _valueValidator.Validate(example.value);
            //DO DATA ACCESS CALLS
            example.id = id;
            _exampleDataAccessor.UpdateExample(example);
            //RETURN
            return;
        }

        public void DeleteExample(int id)
        {
            //VALIDATE, throws error if not valid
            //DO DATA ACCESS CALLS
            _exampleDataAccessor.DeleteExample(id);
            //RETURN
            return;
        }
    }
}
