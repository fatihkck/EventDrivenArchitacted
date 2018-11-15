using EventDrivenArchitacted.Infrastructure.Event;
using EventDrivenArchitacted.Services.Abstract;
using EventDrivenArchitacted.Services.Concrete;
using EventDrivenArchitacted.Services.Concrete.Event.OrderMakeEvent;
using Unity;

namespace EventDrivenArchitacted.DependencyResolve
{
    public static class IocStartup
    {
        public static void Run()
        {

            //register interface container
            IoC.Container.RegisterType<ISubscriptionService, EventSubscriptions>();
            IoC.Container.RegisterType<IEventPublisher, EventPublisher>();
            IoC.Container.RegisterType<IOrderService, OrderService>();

            //event global add
            EventSubscriptions.Add<OrderEmailSend>();
            EventSubscriptions.Add<OrderNotifyWarehouse>();
            EventSubscriptions.Add<OrderSendSmsOwner>();

        }
    }
}
