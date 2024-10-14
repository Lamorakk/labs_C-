using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введіть число:");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"{number} є паліндромом.");
        }
        else
        {
            Console.WriteLine($"{number} не 3є паліндромом.");
        }
    }

    public static bool IsPalindrome(int number)
    {
        string numberString = number.ToString();

        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}