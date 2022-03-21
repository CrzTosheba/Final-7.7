using Delivery.Application.Models;

namespace Delivery.Application.Data;

public static class GlobalRepository
{
    public static BookRepository BookRepository { get; set; }
    public static FoodRepository FoodRepository { get; set; }

    static GlobalRepository()
    {
        BookRepository = new BookRepository();
        BookRepository.AddElement(new PaperBook("Paper", "dfa", 0));
        BookRepository.AddElement(new ElectronicBook("Electronic", ""));
        BookRepository.AddElement(new PaperBook("Физрук", "Сергей Мусаниф", 300));
        BookRepository.AddElement(new PaperBook("Самый странный нуб", "Артем Каменистый", 400));
    }
}