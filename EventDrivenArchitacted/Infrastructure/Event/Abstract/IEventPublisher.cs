namespace EventDrivenArchitacted.Infrastructure.Event
{
    public interface IEventPublisher
    {
        void Publish<T>(T eventMessage);
    }
}
