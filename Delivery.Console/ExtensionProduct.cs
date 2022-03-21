
using Delivery.Application.Models;
namespace Delivery.Application;
public static class ProductExtension
{
    public static void AddProduct<T>(this List<Product> products, List<T> selectedProducts, string message)
        where T : Product
    {
        Console.WriteLine(message);
        for (int i = 1; i <= selectedProducts.Count(); i++)
        {
            Console.WriteLine($"№{i}");
            selectedProducts[i - 1].DisplayInfo();
        }
        var index = AskNumber();
        var selectedProduct = selectedProducts[index-1];
        products.Add(selectedProduct);
        selectedProduct.DisplayInfo();

    }
    static int AskNumber() // метода для запросов числовых значений, если не число, то выдаем ошибку
    {
        while (true)
        {
            var response = Console.ReadLine();
            if (int.TryParse(response, out var number) && number > 0) // парсим то что ввели и проверяемс
            {
                return number;
            }
            Console.WriteLine("Введено не корректное значение");
            
        }



    }
}





