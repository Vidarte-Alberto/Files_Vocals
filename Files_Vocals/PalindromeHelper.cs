using System;
using System.Text.RegularExpressions;

public class PalindromeHelper
{
    public static string FindLargestPalindrome(string text)
    {
        // Eliminar espacios y signos de puntuación
        string cleanText = Regex.Replace(text, @"[\s\p{P}-[.]]", string.Empty).ToLower();

        // Encontrar el palíndromo más grande
        string largestPalindrome = string.Empty;
        for (int i = 0; i < cleanText.Length; i++)
        {
            for (int j = i + 1; j < cleanText.Length; j++)
            {
                string substring = cleanText.Substring(i, j - i + 1);
                if (IsPalindrome(substring) &&
                    substring.Length > largestPalindrome.Length)
                {
                    largestPalindrome = substring;
                }
            }
        }

        return largestPalindrome;
    }

    public static bool IsPalindrome(string str)
    {
        int length = str.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
