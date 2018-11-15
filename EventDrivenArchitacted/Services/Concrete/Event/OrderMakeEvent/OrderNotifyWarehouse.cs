using EventDrivenArchitacted.Infrastructure.Event;
using EventDrivenArchitacted.Services.Messaging;
using System;

namespace EventDrivenArchitacted.Services.Concrete.Event.OrderMakeEvent
{
    public class OrderNotifyWarehouse: IConsumer<MakeOrderEventMsg>
    {
        public void Handle(MakeOrderEventMsg eventMessage)
        {
            Console.WriteLine("Order notify warehouse {0}-{1}", eventMessage.OrderId, eventMessage.Message); ;
        }
    }
}
