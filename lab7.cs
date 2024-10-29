using System;
using System.Threading.Tasks;

class lab7
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  
        Task task1 = Task.Run(() => CalculateSum(100));
        Task task2 = Task.Run(() => CalculateFactorial(10));
        Task task3 = Task.Run(() => CalculatePower(2, 8));
        Task.WaitAll(task1, task2, task3);

        Console.WriteLine("Всі обчислення завершено.");
    }

    static void CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сума чисел від 1 до {n}: {sum}");
    }

    static void CalculateFactorial(int n)
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факторіал {n}: {factorial}");
    }

    static void CalculatePower(int baseNum, int exponent)
    {
        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine($"{baseNum} у степені {exponent}: {result}");
    }
}