// See https://aka.ms/new-console-template for more information

using Delivery.Application.Data;
using Delivery.Application.Models;
using Delivery.Application.Models.Delivery;

var products = new List<Product>();

var books = GlobalRepository.BookRepository.GetData(); // валим в репоз что бы посмотреть книги

Console.WriteLine("Выберите книгу");
for (int i = 1; i <= books.Count(); i++)
{
    Console.WriteLine($"Книга №{i}");
    books[i-1].DisplayInfo();
}

// Получение индекса книги
int.TryParse(Console.ReadLine(), out var index);

var selectedBook = books[index - 1];
products.Add(selectedBook);
products.Add(new Food());

selectedBook.DisplayInfo();


Console.WriteLine("Выберите способ доставки");
// if ("Home")
// var order = new Order<HomeDelivery, Product>().AddProducts(products);

var home = new HomeDeliveryOrder();