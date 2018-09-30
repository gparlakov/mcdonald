using System;
using System.Collections.Generic;
using System.Linq;

namespace mcdonald
{
    public interface ISinger
    {
        string Sing(IEnumerable<IAnimal> enumerable);
    }
}
