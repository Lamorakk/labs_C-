using System;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public delegate int Operation(int x, int y);

class lab6
{
    static void Main()
    {
        Operation operation = Calculator.Add;
        Console.WriteLine("Add: " + operation(10, 5)); // Виведе "Add: 15"

        operation = Calculator.Subtract;
        Console.WriteLine("Subtract: " + operation(10, 5)); // Виведе "Subtract: 5"

        operation = Calculator.Multiply;
        Console.WriteLine("Multiply: " + operation(10, 5)); // Виведе "Multiply: 50"
    }
}