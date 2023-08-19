using OnlineStore.Data.Models;

namespace OnlineStore.Data.Services
{
    public interface IDataAccessService
    {
        IEnumerable<Category> GetCategoriesFromJson();
        Category GetCategoryById(int id);
        Task<IEnumerable<Category>> GetCategoriesFromJsonAsync();
        public IEnumerable<Product> GetProductsFromJson();
        Task<IEnumerable<Product>> GetProductsFromJsonAsync();
        IEnumerable<int> GetProductIdsByCategory(int categoryId);
        IEnumerable<Product> GetProductsByCategory(int categoryId);
        Product GetProductById(int id);

    }
}
