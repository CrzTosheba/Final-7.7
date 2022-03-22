using Delivery.Helpers;
using System;

namespace Delivery.Application;
public static class DeliveryExtension
{
    public static Models.Abstarct.Delivery SetDelivery(this List<Models.Abstarct.Delivery> deliverys, string message)
    {
        Console.WriteLine(message);
        for (int i = 1; i <= deliverys.Count(); i++)
        {
            Console.WriteLine($"№{i}");
            deliverys[i - 1].Print();
        }
        var index = IOHelper.AskNumber(max: deliverys.Count() + 1);
        var selected = deliverys[index-1];
        selected.SetDelivery();

        return selected;
    }

}





