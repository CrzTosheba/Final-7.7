using Delivery.Application.Models;

namespace Delivery.Application.Data;

public class BookRepository : Repository<Book>
{ 
    public override List<Book> GetData()
    {
        return Data;
    }

    public override void AddElement(Book element)
    {
        Data.Add(element);
    }
}