using System;
using System.Collections.Generic;
using System.Linq;

namespace mcdonald
{
    public interface ISinger
    {
        string Sing();

        string Sing(IEnumerable<Animal> enumerable);

    }
}