using System;

public interface IShape
{
    double CalculateArea();
}

public class Shape : IShape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Shape: {Name}");
    }

    public virtual double CalculateArea()
    {
        return 0.0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2); // Площа = π * r^2
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}

public class lab4
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        circle.Display(); 
    }
}