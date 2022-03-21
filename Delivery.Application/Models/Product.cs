namespace Delivery.Application.Models;

public abstract class Product
{
    public string Name { get; set; }

    public abstract void DisplayInfo();
}