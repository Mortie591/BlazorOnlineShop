using OnlineStore.Data.Models;

namespace OnlineStore.Data.Services
{
    public interface IDataAccessService
    {
        IEnumerable<Category> GetCategoriesFromJson();
        Task<IEnumerable<Product>> GetProductsFromJsonAsync();
        Task<IEnumerable<Category>> GetCategoriesFromJsonAsync();
        IEnumerable<int> GetProductIdsByCategory(int categoryId, IEnumerable<Product> products);
        IEnumerable<Product> GetProductsByCategory(int categoryId, IEnumerable<Product> products);
    }
}
