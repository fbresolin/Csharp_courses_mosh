class Program
{
    static void Main()
    {
        testing();
    }
    public static void testing()
    {
        string path = @"D:\Users\breso\Downloads\AVPGcURN.txt";
        Exercises.Exercise1(path);
        Exercises.Exercise2(path);
    }
}
class Exercises
{
    public static void Exercise1(string path)
    {
        Console.WriteLine($"Number of words is {GetNumberOfWords(path)}");
    }
    public static int GetNumberOfWords(string path)
    {
        string text = File.ReadAllText(path);
        string[] array = text.Split(' ');
        return array.Count();
    }
    public static void Exercise2(string path)
    {
        Console.WriteLine($"Biggest word is {GetMaxWord(path)}");
    }
    public static string GetMaxWord(string path)
    {
        string text = File.ReadAllText(path);
        string[] array = text.Split(' ');
        string output = array[0];
        int length = output.Length;
        foreach (string word in array)
        {
            if (word.Length <  length)
            {
                output = word;
                length = word.Length;
            }
        }
        return output;
    }
}