using System;
using System.Linq;

namespace mcdonald
{
    class Program
    {
        private static Func<string, string, string> Verse =
         (animal, sound) => $@"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a {animal} E-I-E-I-O
With a {sound} {sound} here
And a {sound} {sound} there
Here a {sound}, there a {sound}
Everywhere a {sound}{sound}
Old MacDonald had a farm E-I-E-I-O";

        static void Main(string[] args)
        {
            var animals = new Animal[] {
                new Animal("Dog", "bark"),
                new Animal("Cat", "meaw"),
                new Animal("Cow", "moo"),
            };

            var sounds = animals.Select(a => Verse(a.Name, a.Sound));
            var all = string.Join(Environment.NewLine, sounds);

            Console.WriteLine(all);
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

    public interface IVerse
    {

    }
}
