class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push("asldkfjsadflkç");
        stack.Push(new List<int>());
        stack.Push(2);
        stack.Clear();

        stack.Push(1);
        stack.Push("asldkfjsadflkç");
        stack.Push(new List<int>());
        stack.Push(2);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
    }
}
