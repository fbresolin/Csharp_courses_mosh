class Program
{
    static void Main2()
    {
        Exercises.Exercise5();
    }

}

public class Exercises
{
    public static void Exercise1()
    {
        int counter = 0;
        for (double i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }

    public static void Exercise2()
    {
        int summation = 0;
        while (true)
        {
            Console.WriteLine("Write a number:");
            summation += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Summation is: {summation}");
        }
        
    }

    public static void Exercise3()
    {
        Console.WriteLine("Enter a number:");
        int res = 1;
        int fat = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= fat; i++)
        {
            res *= i;
        }
        Console.WriteLine($"Its fatorial is: {res}");
    }
        
    public static void Exercise4()
    {
        int minval = 1;
        int maxval = 10;
        int random = Random.Shared.Next(minval, maxval);
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Pick a guess between {minval} and {maxval}");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == random)
            {
                Console.WriteLine("Success, you choose right!");
                return;
            }
        }
        Console.WriteLine("Sorry pal, bad luck");
    }

    public static void Exercise5()
    {
        Console.WriteLine("Enter a sequence of numbers separated by comma");
        string input = Console.ReadLine();
        int arr = Array.ConvertAll(input.Split(','), s => int.Parse(s)).Max();
        Console.WriteLine($"The array max value is {arr}");        
    }
}