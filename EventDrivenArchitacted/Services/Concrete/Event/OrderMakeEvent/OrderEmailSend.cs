using EventDrivenArchitacted.Infrastructure.Event;
using EventDrivenArchitacted.Services.Messaging;
using System;

namespace EventDrivenArchitacted.Services.Concrete.Event.OrderMakeEvent
{
    public class OrderEmailSend : IConsumer<MakeOrderEventMsg>
    {
        public void Handle(MakeOrderEventMsg eventMessage)
        {
            Console.WriteLine("Order email sended {0}-{1}",eventMessage.OrderId,eventMessage.Message); ;
        }
    }
}
