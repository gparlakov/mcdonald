using System;
using Xunit;
using mcdonald;
using System.Linq;

public class McdonaldVerse
{
    [Fact]
    public void VerseShouldExistAndBeOfTypeIVerse()
    {
        // act
        var verse = new Singer();
        // assert
        Assert.True(verse is ISinger, "Expecting Verse to exist and be of type Verse");
    }

    [Fact]
    public void VerseShouldSing_AndReturnAString()
    {
        // arrange
        var verse = new Singer();
        // act
        var sing = verse.Sing();
        // assert
        Assert.True(sing is string);
    }

    [Fact]
    public void VerseShouldSing_AndReturnTheVerse()
    {
        // arrange
        var verse = new Singer();
        var expectedVerse = @"Old MACDONALD had a farm E-I-E-I-O
And on his farm he had a cow E-I-E-I-O
With a moo moo here
And a moo moo there
Here a moo, there a moo
Everywhere a moo moo
Old MacDonald had a farm E-I-E-I-O";
        // act
        var songActual = verse.Sing();

        // assert
        Assert.StrictEqual(expectedVerse, songActual);
    }


    [Fact]
    public void VerseSing_ShouldAcceptAnimalsList()
    {
        // arrange
        var verse = new Singer();
        // act
        var sing = verse.Sing(Enumerable.Empty<Animal>());
        // assert
        Assert.True(sing is string);
    }
}
