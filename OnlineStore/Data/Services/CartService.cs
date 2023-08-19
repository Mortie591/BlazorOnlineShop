namespace OnlineStore.Data.Services
{
    public class CartService:ICartService
    {
        private int count;

        public int Count => this.count;

        public void IncrementCount()
        {
            this.count++;
        }
    }
}
