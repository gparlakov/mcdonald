using System;
using System.Collections.Generic;
using System.Linq;

namespace mcdonald
{
    public struct Animal : IAnimal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }
}