using EventDrivenArchitacted.DependencyResolve;
using EventDrivenArchitacted.Services.Abstract;
using System;
using Unity;

namespace EventDrivenArchitacted
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dependency
            IocStartup.Run();
            #endregion

            var _orderService = IoC.Container.Resolve<IOrderService>();
            _orderService.MakeOrder(1);

            Console.Read();

        }
    }
}
