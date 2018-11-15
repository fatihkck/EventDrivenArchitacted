namespace EventDrivenArchitacted.Services.Messaging
{
    public class MakeOrderEventMsg
    {
        public int OrderId { get; set; }
        public string Message { get; set; }
    }
}
