namespace Delivery.Application.Models;

public class Food : Product
{
    private double weight;
    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0)
                weight = 0;
            else
                weight = value;
        } 
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name} {Weight}");
    }
}