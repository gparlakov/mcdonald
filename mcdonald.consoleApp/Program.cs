using System;
using System.Collections.Generic;
using System.Linq;
using mcdonald;

namespace mcdonald.consoleApp
{
    public class Program
    {
        private static ISinger singer = new Singer();

        public static void Main(params string[] args)
        {
            IAnimal[] animals;
            if (args is null || args.Length == 0)
            {
                animals = new IAnimal[] {
                    new Animal("cow", "moo"),
                    new Animal("cat", "meow"),
                    new Animal("dog", "bark"),
                    new Animal("horse", "neigh"),
                    new Animal("some chicken", "cluck"),
                };
            }
            else
            {
                animals = ParseAnimals(args, Enumerable.Empty<IAnimal>()).animals.ToArray();
            }
            var verse = singer.Sing(animals);

            Console.WriteLine(verse);
        }

        // take the n and n+1 argument for animal name sound and create an array from those
        private static (IEnumerable<IAnimal> animals, IEnumerable<string> left) ParseAnimals(IEnumerable<string> args, IEnumerable<IAnimal> result)
        {
            if (!(args is null) && args.Count() > 1)
            {
                string name = args.First();
                string sound = args.Skip(1).First();
                var parsedAnimals = result.Concat(new IAnimal[] { new Animal(name, sound) });

                var restOfArgs = args.Skip(2);

                return ParseAnimals(restOfArgs, parsedAnimals);
            }
            else
            {
                return (result, null);
            }
        }
    }
}
