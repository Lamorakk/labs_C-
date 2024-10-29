using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "largeTextFile.txt";

        CreateLargeFileAsync(filePath, 500).GetAwaiter().GetResult();
        ReadFileAsync(filePath).GetAwaiter().GetResult();
    }

    public static async Task CreateLargeFileAsync(string filePath, int wordCount)
    {
        StringBuilder sb = new StringBuilder();
        Random random = new Random();

        // Генерація Lorem Ipsum
        for (int i = 0; i < wordCount; i++)
        {
            sb.Append(GenerateRandomWord(random)).Append(" ");
        }

        await File.WriteAllTextAsync(filePath, sb.ToString());
        Console.WriteLine($"Created file: {filePath}");
    }

    private static string GenerateRandomWord(Random random)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        int wordLength = random.Next(3, 10); 
        char[] word = new char[wordLength];

        for (int j = 0; j < wordLength; j++)
        {
            word[j] = chars[random.Next(chars.Length)];
        }

        return new string(word);
    }

    public static async Task ReadFileAsync(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content = await reader.ReadToEndAsync();
                Console.WriteLine($"File content:\n{content}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
}