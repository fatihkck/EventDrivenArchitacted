using System.Collections.Generic;

namespace EventDrivenArchitacted.Infrastructure.Event
{
    public interface ISubscriptionService
    {
        IEnumerable<IConsumer<T>> GetSubscriptions<T>();
    }
}
