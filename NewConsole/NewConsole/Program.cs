using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] arguments)
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        while (!string.IsNullOrWhiteSpace(text))
            setUpForCount(range, counts, text);
        {
        }
    }
    static void findCounts(int range, int[] counts, string text)
    {
        for (var i = 0; i < range; i++)
        {
            if (counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(counts[i] / (Convert.ToDouble(text.Length)) * 100 + "%");
                Console.WriteLine(character + " - " + counts[i]);
            }
        }
    }
    static void setUpForCount(int range, int[] counts, string text)
    {
        text = Console.ReadLine().ToUpper();
        foreach (var character in text)
        {
            counts[(int)character]++;
        }
        findCounts(range, counts, text);
    }

}