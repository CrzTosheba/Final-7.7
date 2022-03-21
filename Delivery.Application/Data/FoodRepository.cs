using Delivery.Application.Models;

namespace Delivery.Application.Data;

public class FoodRepository : Repository<Food>
{
    public override List<Food> GetData()
    {
        return Data;
    }

    public override void AddElement(Food element)
    {
        Data.Add(element);
    }
}