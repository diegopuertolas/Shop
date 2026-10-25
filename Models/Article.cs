namespace Shop.Models;

public class Article
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Article(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void ShowDescription()
    {
        Console.WriteLine($"{Name} | {Price:C}");
    }
}