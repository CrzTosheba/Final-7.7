
using Delivery.Application.Models;
using Delivery.Helpers;

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
        var index = IOHelper.AskNumber(max: selectedProducts.Count() + 1); 
        var selectedProduct = selectedProducts[index-1];
        products.Add(selectedProduct);
        //selectedProduct.DisplayInfo();

    }
}





