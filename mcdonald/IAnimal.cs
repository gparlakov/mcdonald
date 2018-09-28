using System;
using System.Collections.Generic;
using System.Linq;

namespace mcdonald
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Sound { get; set; }
    }
}