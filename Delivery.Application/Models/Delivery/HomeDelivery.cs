namespace Delivery.Application.Models.Delivery;

public class HomeDelivery : Abstarct.Delivery
{
    public HomeDelivery()
    {
        Address = null;
    }

    public override void SetDelivery()
    {
        while (Address == null || Address.Trim().Length == 0)
        {
            Console.WriteLine("������� ����� �������� (�� ����� ���� ������)");
            Address = Console.ReadLine();
        }

        base.SetDelivery();
    }
}