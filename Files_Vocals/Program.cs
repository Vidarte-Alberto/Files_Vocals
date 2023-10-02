using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "./Lorem.txt"; // Reemplaza con la ruta de tu archivo

        // Leer el contenido del archivo
        string content = File.ReadAllText(filePath);

        // Encontrar el número máximo de vocales y sustituir la última vocal
        string vowels = "aeiou";
        int[] vowelCounts = VowelHelper.CountVowels(content);

        foreach (char vowel in vowels)
        {
            int lastVowelIndex = content.LastIndexOf(vowel);
            if (lastVowelIndex != -1)
            {
                int vowelCount = vowelCounts[vowels.IndexOf(vowel)];
                content = content.Remove(lastVowelIndex, 1).Insert(lastVowelIndex, vowelCount.ToString() + "|");
            }
        }


        // Encontrar el palíndromo más grande
        string largestPalindrome = PalindromeHelper.FindLargestPalindrome(content);

        // Modificar el archivo original con los resultados
        File.WriteAllText(filePath, content);

        // Mostrar el número de vocales encontradas
        // Mostrar el número de vocales encontradas
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\nNúmero de vocales encontradas:");
        for (int i = 0; i < vowels.Length; i++)
        {
            sb.AppendLine($"{vowels[i]} - {vowelCounts[i]}");
        }

        // Mostrar el palíndromo más grande
        sb.AppendLine($"Palíndromo más grande: {largestPalindrome}");

        // Agregar el contenido al final del archivo
        File.AppendAllText(filePath, sb.ToString());
    }
}
