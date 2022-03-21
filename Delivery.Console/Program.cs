// See https://aka.ms/new-console-template for more information

using Delivery.Application;
using Delivery.Application.Data;
using Delivery.Application.Models;
using Delivery.Application.Models.Delivery;
using System.Collections.Generic;

var products = new List<Product>();
var books = GlobalRepository.BookRepository.GetData();
var foods = GlobalRepository.FoodRepository.GetData();
products.AddProduct(books, message: "Выберите книгу");
products.AddProduct(foods, message: "Выберите хавку");

Console.WriteLine("Выберите способ доставки");

