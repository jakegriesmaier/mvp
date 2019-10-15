using Domain.Entities;
using mvp.ViewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvp.Mappers
{
    internal static class ExampleMapper
    {
        internal static ExampleViewData map(Example example)
        {
            return new ExampleViewData {
                id = example.id,
                value = example.value
            };
        }

        internal static Example map(ExampleViewData example)
        {
            return new Example
            {
                id = example.id,
                value = example.value
            };
        }
    }
}
