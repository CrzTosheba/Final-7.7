namespace Delivery.Application.Models;

public static class ProductExtension
{
    public static void DisplayName(Product product)
    {
        Console.WriteLine(product.Name);
    }
}