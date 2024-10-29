using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> _elements;

    public MyStack()
    {
        _elements = new List<T>();
    }

    public void Push(T item)
    {
        _elements.Add(item);
    }

    public T Pop()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Стек порожній.");
        }

        T item = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Стек порожній.");
        }

        return _elements[_elements.Count - 1];
    }

    // Перевірка наявності елементів у стеку
    public bool IsEmpty()
    {
        return _elements.Count == 0;
    }

    // Кількість елементів у стеці
    public int Count()
    {
        return _elements.Count;
    }
}

class lab5
{
    static void Main()
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Peek()); // Виведе 3
        Console.WriteLine(stack.Pop());  // Виведе 3
        Console.WriteLine(stack.Count()); // Виведе 2
    }
}