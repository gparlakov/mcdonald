using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace mcdonald
{
    public class Singer : ISinger
    {
        private Func<Animal, string> verseFunc;

        private Func<Animal, string> VerseDefault =
         (animal) => $@"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a {animal.Name} E-I-E-I-O
With a {animal.Sound} {animal.Sound} here
And a {animal.Sound} {animal.Sound} there
Here a {animal.Sound}, there a {animal.Sound}
Everywhere a {animal.Sound}{animal.Sound}
Old MacDonald had a farm E-I-E-I-O";

        public Singer(Func<Animal, string> verseFunc = default(Func<Animal, string>))
        {
            this.verseFunc = verseFunc ?? VerseDefault;
        }

        public string Sing(IEnumerable<Animal> enumerable)
        {
            return string.Empty;
        }

        public string Sing()
        {
            return verseFunc(new Animal("cow", "moo"));
        }
    }
}