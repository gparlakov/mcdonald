using System;
using Xunit;
using mcdonald;
using System.Linq;
using System.Collections.Generic;

public class McdonaldVerse
{
    [Fact]
    public void VerseShouldExistAndBeOfTypeIVerse()
    {
        // act
        var singer = new Singer();
        // assert
        Assert.True(singer is ISinger, "Expecting Verse to exist and be of type Verse");
    }

    [Fact]
    public void Singer_Sing_ShouldAcceptAnimalsList()
    {
        // arrange
        var singer = new Singer();
        // act
        var sing = singer.Sing(Enumerable.Empty<IAnimal>());
        // assert
        Assert.True(sing is string);
    }

    [Fact]
    public void SingerShouldSing_AndReturnAString()
    {
        // arrange
        var singer = new Singer();
        // act
        var sing = singer.Sing(Enumerable.Empty<IAnimal>());
        // assert
        Assert.True(sing is string);
    }

    [Fact]
    public void SingerShouldAcceptVerse()
    {
        // act
        var singer = new Singer(a => "verse");
    }

    [Fact]
    public void SingerShouldAcceptVerse_AndUseItToSing()
    {
        // arrange
        var expectedVerse = "verse";
        var singer = new Singer(a => "verse");
        var animals = new IAnimal[] { new Animal("t", "t")};
        // act
        var verse = singer.Sing(animals);
        // assert
        Assert.StrictEqual(expectedVerse, verse);
    }

        [Fact]
    public void SingerShouldAcceptVerse_AndAnimalsCollection_AndUseThemToSing()
    {
        // arrange
        var expectedVerse = "cat-meow\ndog-bark\n";
        var singer = new Singer(a => $"{a.Name}-{a.Sound}\n");
        var animals = new IAnimal[] { new Animal("cat", "meow"), new Animal("dog", "bark")};
        // act
        var verse = singer.Sing(animals);
        // assert
        Assert.StrictEqual(expectedVerse, verse);
    }

    [Fact]
    public void Singer_WithDefaultVerse_AndTwoAnimals_ShouldSingTheTwoAnimalVerse()
    {
        // arrange
        var verse = new Singer();
        var expectedVerse = @"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a cow E-I-E-I-O
With a moo moo here
And a moo moo there
Here a moo, there a moo
Everywhere a moo moo
Old MacDonald had a farm E-I-E-I-O

Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a cat E-I-E-I-O
With a meow meow here
And a meow meow there
Here a meow, there a meow
Everywhere a meow meow
Old MacDonald had a farm E-I-E-I-O

";

        IEnumerable<IAnimal> animals = new IAnimal[] {
            new Animal("cow", "moo"),
            new Animal("cat", "meow"),
        };
        // act
        var songActual = verse.Sing(animals);

        // assert
        Assert.StrictEqual(expectedVerse, songActual);
    }


    [Fact]
    public void Singer_WithDefaultVerse_AndFiveAnimals_ShouldSingTheFiveAnimalVerse()
    {
        // arrange
        var verse = new Singer();
        var expectedVerse = @"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a cow E-I-E-I-O
With a moo moo here
And a moo moo there
Here a moo, there a moo
Everywhere a moo moo
Old MacDonald had a farm E-I-E-I-O

Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a cat E-I-E-I-O
With a meow meow here
And a meow meow there
Here a meow, there a meow
Everywhere a meow meow
Old MacDonald had a farm E-I-E-I-O

Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a dog E-I-E-I-O
With a bark bark here
And a bark bark there
Here a bark, there a bark
Everywhere a bark bark
Old MacDonald had a farm E-I-E-I-O

Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a pig E-I-E-I-O
With a oink oink here
And a oink oink there
Here a oink, there a oink
Everywhere a oink oink
Old MacDonald had a farm E-I-E-I-O

Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a horse E-I-E-I-O
With a neigh neigh here
And a neigh neigh there
Here a neigh, there a neigh
Everywhere a neigh neigh
Old MacDonald had a farm E-I-E-I-O

";

        IEnumerable<IAnimal> animals = new IAnimal[] {
            new Animal("cow", "moo"),
            new Animal("cat", "meow"),
            new Animal("dog", "bark"),
            new Animal("pig", "oink"),
            new Animal("horse", "neigh"),
            };
        // act
        var songActual = verse.Sing(animals);

        // assert
        Assert.StrictEqual(expectedVerse, songActual);
    }

}
