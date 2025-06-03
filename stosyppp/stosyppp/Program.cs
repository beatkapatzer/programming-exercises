//1.Napisz własną implementację stosu w języku programowania. Implementacja powinna wykonywać podstawowe operacje na stosie: push, pop i peek  
using System;

public class Stack<T>
{
    private List<T> elements = new List<T>();

    public void Push(T item) => elements.Add(item);

    public T Pop()
    {
        var top = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return top;
    }

    public T Peek() => elements[elements.Count - 1];

    public bool IsEmpty() => elements.Count == 0;
}

public class Program
{
    public static void Main(string[] args)
    {
        var stack = new Stack<string>();
        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());

        stack.Pop();
        stack.Pop();

        Console.WriteLine(stack.IsEmpty());
    }
}
