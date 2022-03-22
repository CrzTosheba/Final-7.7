using Delivery.Application.Models;
using Delivery.Application.Models.Delivery;

namespace Delivery.Application.Data;

public static class GlobalRepository
{
    public static BookRepository BookRepository { get; set; }
    public static FoodRepository FoodRepository { get; set; }

    public static DeliveryRepo DeliveryRepository { get; set; }

    static GlobalRepository()
    {
        BookRepository = new BookRepository();
        BookRepository.AddElement(new PaperBook("Играть что бы жить:", "Дмитрий Рус", 10000));
        BookRepository.AddElement(new ElectronicBook("Electronic", ""));
        BookRepository.AddElement(new PaperBook("Физрук:", "Сергей Мусаниф", 300));
        BookRepository.AddElement(new PaperBook("Самый странный нуб:", "Артем Каменистый", 400));
        FoodRepository = new FoodRepository();
        FoodRepository.AddElement(new Food("Сосико, вес грамм:", 200));
        FoodRepository.AddElement(new Food("Банан, вес грамм:", 123));
        FoodRepository.AddElement(new Food("Говядина, вес грамм:", 323));
        FoodRepository.AddElement(new Food("Молоко, вес грамм:", 243));

        DeliveryRepository = new DeliveryRepo();
        DeliveryRepository.AddElement(new PickPointDelivery("Одинцово 1"));
        DeliveryRepository.AddElement(new PickPointDelivery("Одинцово 2"));
        DeliveryRepository.AddElement(new ShopDelivery("Магаз 1"));
        DeliveryRepository.AddElement(new ShopDelivery("Магаз 2"));
        DeliveryRepository.AddElement(new HomeDelivery());



    }
}