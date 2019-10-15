using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvp.ViewData
{
    /// <summary>
    /// Data type for Example Entity that will be returned to the view, notice how the "confidential" field is not included
    /// </summary>
    public class ExampleViewData
    {
        public int id { get; set; }
        public string value { get; set; }
    }
}
