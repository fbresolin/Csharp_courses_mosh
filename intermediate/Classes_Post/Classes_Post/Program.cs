class Program
{
    static void Main()
    {
        Post post = new Post("ola", "tudo bem, eu tenho uma duvida");
        Console.WriteLine($"O titulo do post é '{ post.Title }'");
        Console.WriteLine($"A descricao do post é '{ post.Description }'");
        Console.WriteLine($"O post foi criado em { post.CreatedTime }");
        post.AddRating();
        post.AddRating();
        Console.WriteLine($"O rating desse é { post.Rating }");
    }
}

public class Post
{
    public readonly string Title;
    public readonly string Description;
    public readonly DateTime CreatedTime;
    public int Rating { get; private set; }
    public Post(string _title, string _description)
    {
        Title = _title;
        Description = _description;
        CreatedTime = DateTime.Now;
        Rating = 0;
    }

    public void AddRating()
    {
        Rating++;
    }
    public void RemoveRating()
    {
        Rating--;
    }
}