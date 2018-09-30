using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace mcdonald
{
    public class Singer : ISinger
    {
        private Func<IAnimal, string> verseFunc;


        public Singer(Func<IAnimal, string> verseFunc = default(Func<IAnimal, string>))
        {
            this.verseFunc = verseFunc ?? VerseDefault;
        }

        public string Sing(IEnumerable<IAnimal> animals)
        {
            var verses = animals.Select(verseFunc).ToArray();

            return string.Join("", verses);
        }

        private Func<IAnimal, string> VerseDefault =
            (animal) => $@"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a {animal.Name} E-I-E-I-O
With a {animal.Sound} {animal.Sound} here
And a {animal.Sound} {animal.Sound} there
Here a {animal.Sound}, there a {animal.Sound}
Everywhere a {animal.Sound} {animal.Sound}
Old MacDonald had a farm E-I-E-I-O

";
    }
}
