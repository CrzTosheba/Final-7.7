namespace Delivery.Application.Models;

public class Book : Product
{
    public string Author { get; set; }

    public Book(string name, string author)
    {
        Name = name;
        Author = author;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} {Author}");
    }

    public static bool operator == (Book book1, Book book2)
    {
        return book1.Name == book2.Name && book1.Author == book2.Author;
    }

    public static bool operator != (Book book1, Book book2)
    {
        return !(book1 == book2);
    }
}

public class PaperBook : Book
{
    public int Pages { get; set; }

    public new void DisplayInfo()
    { 
        Console.WriteLine($"{Name} {Author} {Pages}");
    }

    public PaperBook(string name, string author, int pages) 
        : base(name, author)
    {
        Pages = pages;
    }
}