namespace Delivery.Application.Data;

public abstract class Repository<T>
{
    protected List<T> Data;

    public Repository()
    {
        Data = new List<T>();
    }

    public virtual List<T> GetData()
        => Data;
    
    public virtual void AddElement(T element)
        => Data.Add(element);
}