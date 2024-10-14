using System;

class lab2
{
    static void Main()
    {
        Console.Write("Введіть 10 елементів масиву, розділених пробілом: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(' ');
        int[] array = new int[inputArray.Length];
        
        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = Convert.ToInt32(inputArray[i]);
        }

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.WriteLine($"Сума всіх елементів масиву: {sum}");
    }
}