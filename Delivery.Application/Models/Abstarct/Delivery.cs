namespace Delivery.Application.Models.Abstarct;

public abstract class Delivery
{
    public string Address { get; protected set; }
    public string DeliveryType => GetType().Name;

    public virtual void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"{DeliveryType}: {Address ?? "Адрес не выбран"}";
    }

    public virtual void SetDelivery() {
        Console.WriteLine("Выбран вариант:");
        Print();
    }
}

