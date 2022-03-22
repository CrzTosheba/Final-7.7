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
            Console.WriteLine("¬ведите адрес доставки (не может быть пустым)");
            Address = Console.ReadLine();
        }

        base.SetDelivery();
    }
}