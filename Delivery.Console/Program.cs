// See https://aka.ms/new-console-template for more information

using Delivery.Application;
using Delivery.Application.Data;
using Delivery.Application.Models;
using Delivery.Application.Models.Delivery;
using System.Collections.Generic;

var products = new List<Product>();
Delivery.Application.Models.Abstarct.Delivery delivery; //dasd

CreateBasket();
Console.WriteLine("Корзина наполнена");
PrintProducts(products, "Содержимое корзины:");
SetDelivery();

void CreateBasket()
{
    var books = GlobalRepository.BookRepository.GetData();
    var foods = GlobalRepository.FoodRepository.GetData();
    var flag = true;
    while (flag)
    {
        Console.WriteLine("№1 показать список");
        Console.WriteLine("№2 Добавить в заказ книгу");
        Console.WriteLine("№3 Добавить в заказ хавку");
        Console.WriteLine("№0 Закончить прокупки");

        var menu = int.TryParse(Console.ReadLine(), out int x) ? x : -1;
        switch (menu)
        {
            case 1:
                PrintProducts(products, "Содержимое корзины:");
                break;
            case 2:
                products.AddProduct(books, message: "Выберите книгу");
                break;
            case 3:
                products.AddProduct(foods, message: "Выберите хавку");
                break;
            case 0:
                flag = false;
                break;
            default:
                break;
        }
    }
}

void PrintProducts(List<Product> products, string header = "", string footer = "")
{
    Console.WriteLine("-------------------------");
    if(header != "")
        Console.WriteLine(header);
    foreach (var product in products)
        product.DisplayInfo();
    if (footer != "")
        Console.WriteLine(footer);
    Console.WriteLine("-------------------------");
    Console.WriteLine();
}

void SetDelivery()
{
    var deliverys = GlobalRepository.DeliveryRepository.GetData();
    delivery = deliverys.SetDelivery("Выберите способ доставки");
}

PrintProducts(products, header: "Заказ:", footer: $"Будет доставлен:\n{delivery.ToString()}");


