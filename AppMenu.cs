using Shop.Models;

public static class AppMenu
{
    public static void DisplayMenu(List<Article> articles)
    {
        var option = -1;
        do
        {
            ShowMenu();
            option = ChooseOption();

            switch (option)
            {
                case 1:
                    Console.WriteLine();
                    SearchCheapestArticle(articles);
                    break;
                case 2:
                    Console.WriteLine();
                    AveragePrice(articles);
                    break;
                case 3:
                    Console.WriteLine();
                    SearchMaximunPrice(articles);
                    break;
                case 0:
                    Console.WriteLine("\n Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\n Opción no válida. Incluya un número del 0 al 3.");
                    break;
            }

        } while (option != 0);
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n=== TIENDA ===");
        Console.WriteLine("1. Artículo más barato");
        Console.WriteLine("2. Precio medio");
        Console.WriteLine("3. Buscar por precio máximo");
        Console.WriteLine("0. Salir");
    }

    public static int ChooseOption()
    {
        Console.Write("\nEliga una opcion: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var decision))
        {
            return -1;
        }

        return decision;
    }

    public static void SearchCheapestArticle(List<Article> articles)
    {
        var cheapest = articles[0];

        foreach (var article in articles)
        {
            if (article.Price < cheapest.Price)
            {
                cheapest = article;
            }
        }

        Console.Write("El artículo más barato es: ");
        cheapest.ShowDescription();
    }

    public static decimal CheapestPrice(List<Article> articles)
    {
        var cheapest = articles[0];

        foreach (var article in articles)
        {
            if (article.Price < cheapest.Price)
            {
                cheapest = article;
            }
        }

        return cheapest.Price;
    }

    public static void AveragePrice(List<Article> articles)
    {
        decimal sum = 0;

        foreach (var article in articles)
        {
            sum += article.Price;
        }

        var average = sum / articles.Count;

        Console.WriteLine($"Precio medio: {average:C}");
    }

    public static void SearchMaximunPrice(List<Article> articles)
    {
        Console.Write("Introduzca el precio máximo: ");
        
        var input = Console.ReadLine();
        
        if (!decimal.TryParse(input, out var decision))
        {
            Console.WriteLine("\nPrecio incorrecto.");
            return;
        }

        foreach (var article in articles)
        {
            if (article.Price <= decision)
            {
                article.ShowDescription();
            }
        }

        if (decision < CheapestPrice(articles))
        {
            Console.WriteLine("\nNo hay ningún artículo más barato que ese precio.");
        }
    }

}