using System.Text;

class Chuchu
{
    static void Main()
    {
        Exercises.Exercise4();
    }
}
public static class Exercises
{
    public static void Exercise1()
    {
        Console.WriteLine("Enter a few numbers separated by hyphen (-):");
        string str = Console.ReadLine();
        IsValidSequence(str);
    }
    public static void IsValidSequence(string str)
    {
        int[] list = str.Split('-').Select(s => Convert.ToInt32(s)).ToArray();
        list = (list.First() > list.Last()) ? list.Reverse().ToArray() : list;
        for (int i = 0; i < list.Length - 1; i++)
        {
            if (list[i] + 1 != list[i + 1])
            {
                Console.WriteLine("Invalid sequence");
                return;
            }
        }
        Console.WriteLine("Valid sequence");
    }
    public static void Exercise2()
    {
        Console.WriteLine("Enter a few numbers separated by hyphen (-):");
        string str = Console.ReadLine();
        if (String.IsNullOrEmpty(str)) return;
        int[] list = str.Split('-').Select(int.Parse).ToArray();
        if (!(list.Distinct().ToArray().Count() == list.Count())) Console.WriteLine("Duplicated");

    }
    public static void Exercise3()
    {
        Console.WriteLine("Input a valid time:");
        string str = Console.ReadLine();
        try
        {
            Console.WriteLine(Convert.ToDateTime(str).ToString());
            Console.WriteLine("ok");
        }
        catch
        {
            Console.WriteLine("Invalid Time");
        }
    }
    public static void Exercise4()
    {
        Console.WriteLine("Enter words separated by space");
        string str = Console.ReadLine();
        RemoveSpacesAndCapitalize(str);
    }
    public static void RemoveSpacesAndCapitalize(string str)
    {
        StringBuilder strwrt = new StringBuilder();
        string[] array = str.Split().ToArray();
        for (int i = 0; i < array.Length; i++)
        {
            strwrt.Append(array[i].Substring(0, 1).ToUpper() + array[i].Substring(1, array[i].Length - 1));
        }
        Console.WriteLine(strwrt);
    }
    public static void Exercise5()
    {
        Console.WriteLine("Write a word");
        string str = Console.ReadLine();
        int countVogals = str.Count(c => (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'));
        Console.WriteLine($"Number of vogals is {countVogals}");

    }
}