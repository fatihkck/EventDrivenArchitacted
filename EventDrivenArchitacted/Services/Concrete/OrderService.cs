using EventDrivenArchitacted.Infrastructure.Event;
using EventDrivenArchitacted.Services.Abstract;
using EventDrivenArchitacted.Services.Messaging;
using System;

namespace EventDrivenArchitacted.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IEventPublisher _eventPublisher;

        public OrderService(IEventPublisher eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }

        public void MakeOrder(int orderId)
        {
            Console.WriteLine("Order success.");

            _eventPublisher.Publish(new MakeOrderEventMsg { OrderId = orderId, Message = "Publisher" });
        }
    }
}
