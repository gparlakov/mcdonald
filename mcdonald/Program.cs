using System;
using System.Collections.Generic;
using System.Linq;

namespace mcdonald
{
    class Program
    {

        private static ISinger singer = new Singer();

        static void Main(string[] args)
        {
            var animals = new Animal[] {
                new Animal("Dog", "bark"),
                new Animal("Cat", "meaw"),
                new Animal("Cow", "moo"),
            };
            var verse = singer.Sing(animals);
            
            Console.WriteLine(verse);
        }
    }

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

    public interface IAnimal
    {
        string Name { get; set; }
        string Sound { get; set; }
    }

    public interface ISinger
    {
        string Sing();

        string Sing(IEnumerable<Animal> enumerable);

    }
}
