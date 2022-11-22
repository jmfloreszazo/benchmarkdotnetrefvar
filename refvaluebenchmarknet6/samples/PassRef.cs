using System.Text;

public class PassRef
{
    private string SomePassValue1(ref string value)
    {
        return SomePassValue2(ref value);
    }

    private string SomePassValue2(ref string value)
    {
        return SomePassValue3(ref value);
    }

    private string SomePassValue3(ref string value)
    {
        return SomePassValue4(ref value);
    }

    private string SomePassValue4(ref string value)
    {
        var result = "test";
        return result;
    }

    private string LoremIpsum(int minWords, int maxWords,
        int minSentences, int maxSentences,
        int numParagraphs)
    {
        var words = new[]
        {
            "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
            "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod",
            "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam", "erat"
        };

        var rand = new Random();
        var numSentences = rand.Next(maxSentences - minSentences)
                           + minSentences + 1;
        var numWords = rand.Next(maxWords - minWords) + minWords + 1;

        var result = new StringBuilder();

        for (var p = 0; p < numParagraphs; p++)
        for (var s = 0; s < numSentences; s++)
        {
            for (var w = 0; w < numWords; w++)
            {
                if (w > 0) result.Append(" ");

                result.Append(words[rand.Next(words.Length)]);
            }

            result.Append(". ");
        }

        return result.ToString();
    }

    public void SomeMethod()
    {
        var passMe = LoremIpsum(10, 10, 10, 10, 10);
        for (var x = 0; x < 20; x++)
        for (var i = 0; i < 50000000; i++)
            SomePassValue1(ref passMe);
    }
}