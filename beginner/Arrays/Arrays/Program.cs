class Program
{
    static void Main()
    {
        Exercises.Exercise5();
    }
}

public static class Exercises
{
    public static void Exercise1()
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Please enter a name");
            string name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                break;
            }
            list.Add(name);
        }
        if (list.Count == 0)
        {
            return;
        }
        else if (list.Count == 1)
        {
            Console.WriteLine($"{list[0]} likes your post.");
        }
        else if (list.Count == 2)
        {
            Console.WriteLine($"{list[0]} and {list[1]} like your post.");
        }
        else
        {
            string str = list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                str += ", " + list[i];
            }
            Console.WriteLine($"{ str } and {list.Last()} like your post.");
        }

    }
    public static void Exercise2()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        string reversename = "";
        for (int i = name.Length-1; i>= 0; i--)
        {
            reversename += name[i];
        }
        Console.WriteLine(name);
        Console.WriteLine(reversename);
    }
    public static void Exercise3()
    {
        List<int> list = new List<int>();
        do
        {
            Console.WriteLine("Input 5 numbers");
            int value = Convert.ToInt32(Console.ReadLine());
            if (list.Contains(value))
            {
                Console.WriteLine("Wrong input, repeated number");
            }
            else
            {
                list.Add(value);
            }
        } while (list.Count() <= 5);
        list.Sort();
        Console.WriteLine("Sorted list");
        for (int i = 0; i < list.Count(); i++)
        {
            Console.WriteLine(list[i]);
        }

    }
    public static void Exercise4()
    {
        List<int> list = new List<int>();
        while (true)
        {
            Console.WriteLine("Input a number, to quit write 'Quit'");
            string str = Console.ReadLine();
            if (str == "Quit")
            {
                for (int i = 0;i < list.Count(); i++)
                {
                    Console.WriteLine(list[i]);
                    
                }
                return;
            }
            list.Add(Convert.ToInt32(str));
        }
    }
    public static void Exercise5()
    {
        while (true)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Input 5 numbers separated by comma");
            string str = Console.ReadLine();
            int[] array = Array.ConvertAll(str.Split(','), s => int.Parse(s));
            if (array.Length == 5)
            {
                Array.Sort(array);
                Console.WriteLine("List of the 3 lesser numbers");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(array[i]);
                }
                return;
            }
            else
            {
                Console.WriteLine("Wrong input.");
            }
        }
    }
}