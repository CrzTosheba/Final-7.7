namespace Delivery.Application.Models;

public class Food : Product
{
    private double weight;

    public Food(string name, double weight)
    {
        Name = name;
        this.weight = weight;
    }

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
public class GoodFood : Food
{
    public GoodFood(string name, double Weight) : base(name, Weight)
    {
    }
}
