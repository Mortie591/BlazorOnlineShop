namespace OnlineStore.Data.Services
{
    public interface ICartService
    {
        public int Count { get; }
        public void IncrementCount();
    }
}