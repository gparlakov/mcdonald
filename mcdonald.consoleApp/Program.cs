using System;
using mcdonald;

namespace mcdonald.consoleApp
{
    public class Program
    {
        private static ISinger singer = new Singer();

        public static void Main(params string[] args)
        {
            var animals = new IAnimal[] {
                new Animal("cow", "moo"),
                new Animal("cat", "meow"),
                new Animal("dog", "bark"),
                new Animal("horse", "neigh"),
                new Animal("some chicken", "cluck"),
            };
            var verse = singer.Sing(animals);

            Console.WriteLine(verse);
        }
    }
}
