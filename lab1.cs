using System;

class lab1
{
    static void Main()
    {
        Console.Write("Введіть радіус кола: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double length = 2 * Math.PI * radius;

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Довжина кола: {length}");
        Console.WriteLine($"Площа кола: {area}");
    }
}

