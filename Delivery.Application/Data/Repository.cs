namespace Delivery.Application.Data;

public abstract class Repository<T>
{
    protected List<T> Data;

    public Repository()
    {
        Data = new List<T>();
    }

    public abstract List<T> GetData();
    
    public abstract void AddElement(T element);
}