namespace Delivery.Application.Models.Delivery;

public class ShopDelivery : Abstarct.Delivery
{
    public ShopDelivery(string v)
    {
        Address = v;
    }
}