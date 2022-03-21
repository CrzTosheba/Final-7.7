using Delivery.Application.Models.Delivery;

namespace Delivery.Application.Models;

public class Order < TDelivery, TStruct > 
    where TDelivery: Abstarct.Delivery 
    where TStruct: Product
{
    public TDelivery Delivery;

    public int Number;

    public string Description; 
    private List<TStruct> Products { get; set; } 

    // public Order(List<TStruct> products)
    // {
    //     Products = new List<TStruct>();
    // }
    
    public void AddProducts(List<TStruct> products)
    {
        Products = products;
    }

    public void DisplayAddress() 
    {
        Console.WriteLine(Delivery.Address);
    }
}

public class HomeDeliveryOrder : Order<HomeDelivery, Product> { }
public class ShopDeliveryOrder : Order<ShopDelivery, Product> { }
