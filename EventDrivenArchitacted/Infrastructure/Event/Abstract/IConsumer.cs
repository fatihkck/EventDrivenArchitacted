namespace EventDrivenArchitacted.Infrastructure.Event
{
    public interface IConsumer<T>
    {
        void Handle(T eventMessage);
    }
}
