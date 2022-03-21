using Delivery.Application.Models;

namespace Delivery.Application.Data;

public static class GlobalRepository
{
    public static BookRepository BookRepository { get; set; }
    public static FoodRepository FoodRepository { get; set; }

    static GlobalRepository()
    {
        BookRepository = new BookRepository();
        BookRepository.AddElement(new PaperBook("������ ��� �� ����:", "������� ���", 10000));
        BookRepository.AddElement(new ElectronicBook("Electronic", ""));
        BookRepository.AddElement(new PaperBook("������:", "������ �������", 300));
        BookRepository.AddElement(new PaperBook("����� �������� ���:", "����� ����������", 400));
        FoodRepository = new FoodRepository();
        FoodRepository.AddElement(new Food("������, ��� �����:", 200));
        FoodRepository.AddElement(new Food("�����, ��� �����:", 123));
        FoodRepository.AddElement(new Food("��������, ��� �����:", 323));
        FoodRepository.AddElement(new Food("������, ��� �����:", 243));



    }
}