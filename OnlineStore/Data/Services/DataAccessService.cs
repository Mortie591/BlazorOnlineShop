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

        public IEnumerable<Product> GetProductsFromJson()
        {
            var json = File.ReadAllText(productsPath);

            products = JsonSerializer.Deserialize<IEnumerable<Product>>(json);

            return products ?? new List<Product>();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            products = this.GetProductsFromJson().Where(x=>x.CategoryId==categoryId);
            
            return products;
        }

        public IEnumerable<int> GetProductIdsByCategory(int categoryId)
        {
            var productIds = this.GetProductsFromJson()
                .Where(x => x.CategoryId == categoryId).Select(x => x.Id);

            return productIds;
        }

        public Category GetCategoryById(int id)
        {
            var category = this.GetCategoriesFromJson().FirstOrDefault(x => x.Id==id);

            return category;
        }

        public Product GetProductById(int id)
        {
            var product = this.GetProductsFromJson().FirstOrDefault(x => x.Id == id);

            return product;
        }
    }
}
