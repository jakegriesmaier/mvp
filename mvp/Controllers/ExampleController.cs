using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvp.Domain.Models;
using mvp.Mappers;
using mvp.ViewData;

namespace mvp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        // reference to the model for this controller/presenter
        private ExampleModel _exampleModel = new ExampleModel();

        // GET api/example
        [HttpGet]
        public ActionResult<IEnumerable<ExampleViewData>> GetAll()
        {
            var output = _exampleModel.GetAllExample();
            return output.Select(ex => ExampleMapper.map(ex)).ToList();// maps each Example in the list to exampleVeiwData
        }

        // GET api/example/{id}
        [HttpGet("{id}")]
        public ActionResult<ExampleViewData> Get(int id)
        {
            var output = _exampleModel.GetExample(id);
            return ExampleMapper.map(output);
        }

        // POST api/example/
        [HttpPost]
        public void Create([FromBody] ExampleViewData example)
        {
            var input = ExampleMapper.map(example);
            _exampleModel.CreateExample(input);
        }

        // PUT api/example/{id}
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] ExampleViewData example)
        {
            var input = ExampleMapper.map(example);
            _exampleModel.UpdateExample(id, input);
        }

        // DELETE api/example/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _exampleModel.DeleteExample(id);
        }
    }
}