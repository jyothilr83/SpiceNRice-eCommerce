namespace SpiceNRice.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int fooditemId, int qty);
        Task<int> RemoveItem(int fooditemId);
        Task<ShoppingCart> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<ShoppingCart> GetCart(string userId);
        Task<bool> DoCheckout();
    }
}