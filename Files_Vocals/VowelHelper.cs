using System;
using System.Linq;

public class VowelHelper
{
    public static int[] CountVowels(string content)
    {
        string vowels = "aeiou";
        int[] vowelCounts = new int[5];

        for (int i = 0; i < content.Length; i++)
        {
            char c = char.ToLower(content[i]);
            if (vowels.Contains(c))
            {
                int index = vowels.IndexOf(c);
                vowelCounts[index]++;
            }
        }

        return vowelCounts;
    }
}
