using Xunit;

public class VowelHelperTests
{
    [Fact]
    public void CountVowels_ReturnsCorrectCounts()
    {
        string content = "aeiou";
        int[] expected = { 1, 1, 1, 1, 1 };
        int[] actual = VowelHelper.CountVowels(content);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CountVowels_ReturnsZeroForEmptyString()
    {
        string content = "";
        int[] expected = { 0, 0, 0, 0, 0 };
        int[] actual = VowelHelper.CountVowels(content);
        Assert.Equal(expected, actual);
    }
}

public class PalindromeHelperTests
{
    [Fact]
    public void IsPalindrome_ReturnsTrueForEmptyString()
    {
        string str = "";
        bool actual = PalindromeHelper.IsPalindrome(str);
        Assert.True(actual);
    }

    [Fact]
    public void IsPalindrome_ReturnsTrueForPalindrome()
    {
        string str = "radar";
        bool actual = PalindromeHelper.IsPalindrome(str);
        Assert.True(actual);
    }

    [Fact]
    public void IsPalindrome_ReturnsFalseForNonPalindrome()
    {
        string str = "hello";
        bool actual = PalindromeHelper.IsPalindrome(str);
        Assert.False(actual);
    }

    [Fact]
    public void FindLargestPalindrome_ReturnsLargestPalindrome()
    {
        string text = "radar anitalavalatina";
        string expected = "anitalavalatina";
        string actual = PalindromeHelper.FindLargestPalindrome(text);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void IsPalindrome_ReturnsTrueForSingleCharacterString()
    {
        string str = "a";
        bool actual = PalindromeHelper.IsPalindrome(str);
        Assert.True(actual);
    }

    [Fact]
    public void FindLargestPalindrome_ReturnsEmptyStringIfNoPalindromes()
    {
        string text = "abc";
        string expected = "";
        string actual = PalindromeHelper.FindLargestPalindrome(text);
        Assert.Equal(expected, actual);
    }
}

public class ProgramTests : IDisposable
{
    private const string FilePath = "./Lorem.txt";

    public ProgramTests()
    {
        // Crear el archivo antes de ejecutar las pruebas
        File.WriteAllText(FilePath, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
    }
    [Fact]
    public void TestFileExists()
    {
        Assert.True(File.Exists(FilePath));
    }

    [Fact]
    public void TestFileContentNotNull()
    {
        string content = File.ReadAllText(FilePath);
        Assert.NotNull(content);
    }

    public void Dispose()
    {
        // Eliminar el archivo después de ejecutar las pruebas
        if (File.Exists(FilePath))
        {
            File.Delete(FilePath);
        }
    }
}
