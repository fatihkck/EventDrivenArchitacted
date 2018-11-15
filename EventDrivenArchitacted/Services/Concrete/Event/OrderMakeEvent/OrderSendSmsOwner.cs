using EventDrivenArchitacted.Infrastructure.Event;
using EventDrivenArchitacted.Services.Messaging;
using System;

namespace EventDrivenArchitacted.Services.Concrete.Event.OrderMakeEvent

{
    public class OrderSendSmsOwner : IConsumer<MakeOrderEventMsg>
    {
        public void Handle(MakeOrderEventMsg eventMessage)
        {
            Console.WriteLine("Sms order send {0}-{1}", eventMessage.OrderId, eventMessage.Message); ;
        }
    }
}
