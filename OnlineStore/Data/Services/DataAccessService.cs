using System.Text.Json;

namespace OnlineStore.Data.Services
{
    using Models;
    public class DataAccessService : IDataAccessService
    {
        private const string categoriesPath = "Data/Source/categories.json";
        private const string productsPath = "Data/Source/products.json";
        private IEnumerable<Product> products;
        private IEnumerable<Category> categories;
        public Task<IEnumerable<Category>> GetCategoriesFromJsonAsync()
        {
            var json = File.ReadAllText(categoriesPath);

            categories = JsonSerializer.Deserialize<IEnumerable<Category>>(json);

            return Task.FromResult(categories ?? new List<Category>());
        }

        public Task<IEnumerable<Product>> GetProductsFromJsonAsync()
        {
            var json = File.ReadAllText(productsPath);

            products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);

            return Task.FromResult(products ?? new List<Product>());
        }

        public IEnumerable<Category> GetCategoriesFromJson()
        {
            var json = File.ReadAllText(categoriesPath);

            categories = JsonSerializer.Deserialize<IEnumerable<Category>>(json);

            return categories ?? new List<Category>();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId, IEnumerable<Product> products)
        {
            var productsByCategory = products.Where(p => p.CategoryId == categoryId);
            return productsByCategory;
        }

        public IEnumerable<int> GetProductIdsByCategory(int categoryId, IEnumerable<Product> products)
        {
            var productIds = products.Where(x => x.CategoryId == categoryId).Select(x => x.Id);

            return productIds;
        }

    }
}
