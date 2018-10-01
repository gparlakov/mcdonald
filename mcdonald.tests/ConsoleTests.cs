using System;
using System.IO;
using System.Text;
using Xunit;
using mcdonald;

public class ConsoleTests
{
    private readonly TestWriter testWriter;

    public ConsoleTests()
    {
        testWriter = new TestWriter();
        Console.SetOut(testWriter);
    }

    [Fact]
    public void DefaultCaseTest()
    {
        // act
        mcdonald.consoleApp.Program.Main();
        // assert

        Assert.True(testWriter.Result().Length > 0, "Expecting to have some output from the default case into the test writer");
    }

    [Fact]
    public void RunAppWithoutParameters_ExpectDefaultMcdonaldVerse()
    {
        // arrange
        var expected = string.Join(Environment.NewLine, new string[] { 
            "Old MACDONALD had a farm E-I-E-I-O",
            "And on his farm he had a cow E-I-E-I-O",
            "With a moo moo here",
            "And a moo moo there",
            "Here a moo, there a moo",
            "Everywhere a moo moo",
            "Old MacDonald had a farm E-I-E-I-O",
            "",
            "Old MACDONALD had a farm E-I-E-I-O",
            "And on his farm he had a cat E-I-E-I-O",
            "With a meow meow here",
            "And a meow meow there",
            "Here a meow, there a meow",
            "Everywhere a meow meow",
            "Old MacDonald had a farm E-I-E-I-O",
            "",
            "Old MACDONALD had a farm E-I-E-I-O",
            "And on his farm he had a dog E-I-E-I-O",
            "With a bark bark here",
            "And a bark bark there",
            "Here a bark, there a bark",
            "Everywhere a bark bark",
            "Old MacDonald had a farm E-I-E-I-O",
            "",
            "Old MACDONALD had a farm E-I-E-I-O",
            "And on his farm he had a horse E-I-E-I-O",
            "With a neigh neigh here",
            "And a neigh neigh there",
            "Here a neigh, there a neigh",
            "Everywhere a neigh neigh",
            "Old MacDonald had a farm E-I-E-I-O",
            "",
            "Old MACDONALD had a farm E-I-E-I-O",
            "And on his farm he had a some chicken E-I-E-I-O",
            "With a cluck cluck here",
            "And a cluck cluck there",
            "Here a cluck, there a cluck",
            "Everywhere a cluck cluck",
            "Old MacDonald had a farm E-I-E-I-O",
            "",
            ""})
            + Environment.NewLine;
        // act
        mcdonald.consoleApp.Program.Main();
        // assert
        Assert.Equal(expected, testWriter.Result());
    }

    [Fact]
    public void TestName()
    {
    //Given
    
    //When
    
    //Then
    }
}

public class TestWriter : TextWriter
{
    private StringBuilder s = new StringBuilder();

    public override Encoding Encoding => Encoding.UTF8;

    public override void WriteLine(string value)
    {
        s.AppendLine(value);
    }

    public override void Write(string value)
    {
        s.Append(value);
    }

    public string Result()
    {
        return s.ToString();
    }
}
