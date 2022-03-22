namespace Delivery.Application.Models.Delivery;

public class PickPointDelivery : Abstarct.Delivery
{
    public PickPointDelivery(string v)
    {
        Address = v;
    }
}