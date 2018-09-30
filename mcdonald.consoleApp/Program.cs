using System;
using mcdonald;

namespace mcdonald.consoleApp
{
    class Program
    {
        private static ISinger singer = new Singer();

        static void Main(string[] args)
        {
            var animals = new IAnimal[] {
                new Animal("Dog", "bark"),
                new Animal("Cat", "meaw"),
                new Animal("Cow", "moo"),
            };
            var verse = singer.Sing(animals);

            Console.WriteLine(verse);
        }
    }
}
