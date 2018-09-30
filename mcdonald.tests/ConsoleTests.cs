using System;
using System.IO;
using System.Text;
using Xunit;
using mcdonald;

public class ConsoleTests
{
    private readonly TestWriter testWriter;
    private readonly TestReader testReader;

    public ConsoleTests()
    {
        testWriter = new TestWriter();
        testReader = new TestReader();
        Console.SetOut(testWriter);
        Console.SetIn(testReader);
    }

    //[Fact]
    public void ShouldPromptForUserInput()
    {
        // arrange
        var expected = string.Join("\n",
            new string[] {"Choose:",
                "1 - Default verse",
                "2 - User defined animals verse",
                "Any other key - exit"})
            + Environment.NewLine;
        // act
        mcdonald.consoleApp.Program.Main();
        // Console.Write("1");
        // assert
        Assert.Equal(expected, testWriter.Result());
    }

    private string standartUserPrompt = string.Join("\n",
            new string[] {"Choose:",
                "1 - Default verse",
                "2 - User defined animals verse",
                "Any other key - exit",
                });

    [Fact]
    public void ShouldAcceptUserInput()
    {
        // arrange
        var expected = string.Join(Environment.NewLine, new string[] {
           standartUserPrompt,
            "1"});

        // act
        mcdonald.consoleApp.Program.Main();
        System.Console.Write("1");
        // assert
        Assert.Equal(expected, testWriter.Result());
    }

    [Fact(Skip = "true")]
    public void DefaultCaseTest()
    {
        // act
        mcdonald.consoleApp.Program.Main();
        // assert

        Assert.True(testWriter.Result().Length > 0, "Expecting to have some output from the default case into the test writer");
    }

    [Fact(Skip = "true")]
    public void RunAppWithoutParameters_ExpectDefaultMcdonaldVerse()
    {
        // arrange
        var expected = string.Join("\n", new string[] { "Old MACDONALD had a farm E-I-E-I-O",
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
}

public class TestReader : TextReader, IDisposable
{
    private MemoryStream stream;
    private StreamReader reader;

    public TestReader()
    {
        stream = new MemoryStream();
        reader = new StreamReader(stream);
    }

    public void InputKey(char key)
    {
        this.stream.Write(new byte[] { (byte)key }, 0, 1);
    }

    public new void Dispose()
    {
        if (reader != null)
        {
            reader.Dispose();
            reader = null;

            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }
        this.Dispose();
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
